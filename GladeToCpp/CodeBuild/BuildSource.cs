using System;
using System.Collections.Generic;
using GladeConstructor.Parser;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GladeConstructor.CodeBuild
{
    /// <summary>
    ///     Writing of .cpp source file
    /// </summary>
    class BuildSource
    {
        long CurrentBufferPosition = 0;

        StreamIOManager IOManager;
        BindingSource DataSource;
        BindingForm CurrentForm { get; set; }

        string SourcePath;

        public BuildSource(string path)
        {
            DataSource = Storage.Parser.FormBindingSources;
            SourcePath = path;
        }

        public void ProcessSources()
        {
            foreach (var objForm in DataSource)
            {
                var form = (BindingForm)objForm;

                if (form.CodeProcess)
                {
                    CurrentForm = form;
                    ProcessSingleSource(form);
                }
            }
        }

        public void ProcessSingleSource(BindingForm form)
        {
            //Initialize the stream for the current class
            form.SourceCodeStream = new MemoryStream();
            // Initialize the IOManager for current Form form
            IOManager = new StreamIOManager(form.SourceCodeStream);

            // Constructor
            WriteConstructors(form);

            // InitComponents
            WriteInitComponents(form);

            // Show function
            WriteText(form.Class + "::" + "Show() {");
            WriteText(Utils.Tabs(1) + "window->show();");
            WriteText("}\n");

            // Close function
            WriteText(form.Class + "::" + "Close() {");
            WriteText(Utils.Tabs(1) + "window->close();");
            WriteText("}\n");

            // Hide function
            WriteText(form.Class + "::" + "Hide() {");
            WriteText(Utils.Tabs(1) + "window->hide();");
            WriteText("}\n");

            // Signal callbacks
            WriteSignalsCallback(form);

            // Write to file
            IOManager.StreamToFile(SourcePath + CurrentForm.Class + ".cpp");
        }

        private void WriteSignalsCallback(BindingForm form)
        {
            // Form signals
            WriteText("// GtkWindow signals Callback");
            foreach (BindingSignal signal in form.Signals)
            {
                WriteText(signal.BuildSourceCallback(form.Class) + "{");
                WriteText(Utils.Tabs(1) + "// Callback code");
                WriteText("}\n");
            }
            WriteText("");

            WriteText("// --- Widgets signals Callbacks");
            foreach (BindingWidget widget in form.Widgets)
            {
                WriteText("// Signal callbacks for Widget " + widget.Id);
                foreach (BindingSignal signal in widget.Signals)
                {
                    WriteText(signal.BuildSourceCallback(form.Class) + "{");
                    WriteText(Utils.Tabs(1) + "// Callback code");
                    WriteText("}\n");
                }
                WriteText("");
            }
        }

        private void WriteConstructors(BindingForm form)
        {
            WriteText(form.Class + "::" + form.Class + "() {");
            WriteText(Utils.Tabs(1) + "InitComponents();");
            WriteText("}");
            WriteText("");

            WriteText(form.Class + "::" + form.Class + "(Glib::Dispatcher *dispatcher) {");
            WriteText(Utils.Tabs(1) + form.Class + "Dispatcher = dispatcher;");
            WriteText("}");
            WriteText("");
        }

        private void WriteInitComponents(BindingForm form)
        {
            WriteText(form.Class + "::" + "InitComponents() {");
            WriteText(Utils.Tabs(1) + "builder->get_widget(\"" + form.Id + "\", window);");
            WriteText("");
            WriteText(Utils.Tabs(1) + "// Widgets initialisation");
            List<string> initcomplist = new List<string>();
            foreach (BindingWidget widget in form.Widgets)
            {
                if (widget.AddToClass)
                {
                    initcomplist.Add(Utils.Tabs(1) + "builder->get_widget(\"" + widget.Name + "\"," + widget.VariableName + ");");
                }
            }
            IOManager.WriteListOfStringIntoStream(initcomplist);
            WriteText("}");
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
            IOManager.SetStreamPosition(CurrentBufferPosition);
        }
    }
}
