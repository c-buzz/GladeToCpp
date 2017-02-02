using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GladeConstructor.GladeParser;
using GladeConstructor.CodeBuild;
using System.Windows.Forms;

namespace GladeConstructor.CodeBuild
{
    class BuildHeaders
    {
        Stream HeaderFileStream;
        long CurrentBufferPosition = 0;

        StreamIOManager IOManager;
        BindingSource DataSource;
        BindingForm CurrentForm { get; set; }

        string SourcePath;

        public BuildHeaders(string path)
        {
            DataSource = GuiManager.Parser.FormBindingSources;
            SourcePath = path;
        }

        public void ProcessHeaders()
        {
            foreach (var objForm in DataSource)
            {
                var form = (BindingForm)objForm;
                
                if (form.CodeProcess)
                {
                    CurrentForm = form;
                    BuildHeader(form);
                }
            }
        }

        private void BuildHeader(BindingForm form)
        {
            //Initialize the stream for the current class
            HeaderFileStream = new MemoryStream();
            IOManager = new StreamIOManager(HeaderFileStream);

            // Head
            WriteHead(CurrentForm.Class);

            // Public methods and vars
            WriteConstructor(form.Class);
            WriteConstructor(form.Class, "Glib::Dispatcher *dispatcher");
            WriteVariable(new Utils.CppVariable("Gtk::Window", "window", true));
            WritePrototype("void", "Show");
            WritePrototype("void", "Hide");
            WritePrototype("void", "Close");

            // Private members
            WriteText(Utils.Tabs(1) + "private:");
            //Widgets
            WriteWidgetStruct();
            WritePrototype("void","Init");
            //TODO CALLBACKS SIGNAL

            // Write to file
            IOManager.StreamToFile(SourcePath + CurrentForm.Class + ".h");

        }

        private void WriteWidgetStruct(string struct_name = "_struct", string widget_varname = "widgets")
        {
            WriteText(Utils.Tabs(2) + "struct _widgets {");
            foreach (BindingWidget widgets in CurrentForm.Widgets)
            {
                if (widgets.AddToClass)
                {
                    WriteVariable(new Utils.CppVariable("Gtk::" + widgets.Name, widgets.VariableName, true),3);
                }
            }
            WriteText(Utils.Tabs(2) + "} " + widget_varname + ";");
        }

        private void WriteText(string text, bool ret = true)
        {
            if (ret)
            {
                text += "\n";
            }
            IOManager.WriteTextIntoStream(text);
        }

        private void WriteVariable(Utils.CppVariable variable, int tabs = 2)
        {
            WriteText(variable.Declaration(tabs));
        }

        private void WriteVariable(string type, string name, int tabs = 2)
        {
            WriteText(Utils.Tabs(tabs) + type + " " + name + ";");
        }

        private void WriteConstructor(string className, string[] args = null, int tabs = 2)
        {
            WritePrototype("", className, args, tabs);
        }

        private void WriteConstructor(string className, string arg, int tabs = 2)
        {
            WritePrototype("", className, arg, tabs);
        }

        private void WritePrototype(string type, string method, string arg, int tabs = 2)
        {
            string prototype = Utils.Tabs(tabs) + type;
            if (type.Length > 0)
            {
                prototype += " ";
            }
            prototype += method + "(" + arg + ");";
            WriteText(prototype);
        }

        private void WritePrototype(string type, string method, string[] args = null, int tabs = 2)
        {
            string arg = (args != null) ? String.Join(", ", args) : "";
            WritePrototype(type, method, arg, tabs);
        }



        /// <summary>
        ///     It writes the head and the conclusion of a .h c++ file
        /// </summary>
        /// <param name="className">The name of the C++ class to be implemented</param>
        private void WriteHead(string className)
        {
            // Create the string of the head
            List<string> headlist = new List<string>();
            headlist.Add("#ifndef _" + className.ToUpper() + "_H_");
            headlist.Add("#define _" + className.ToUpper() + "_H_");
            headlist.Add("\n");
            headlist.Add("#include \"gtkmm.h\"");
            headlist.Add("\n");
            headlist.Add("class " + className + " {");
            headlist.Add(Utils.Tabs(1) + "public:");
            headlist.Add("\n");

            // Transform the portion of text to array of bytes
            // Point the current position of the buffer to the end of the stream
            CurrentBufferPosition = IOManager.WriteListOfStringIntoStream(headlist);

            // Clear the list
            headlist.Clear();

            // Continue with the end of the head class
            headlist.Add("};");
            headlist.Add("\n");
            headlist.Add("#endif /* _" + className + "_H_ */");

            // Write the second part of the head class to the HeaderFileStream
            IOManager.WriteListOfStringIntoStream(headlist);
            // Bring back to the begin of the public methods declaration
            HeaderFileStream.Position = CurrentBufferPosition;
        }
    }
}
