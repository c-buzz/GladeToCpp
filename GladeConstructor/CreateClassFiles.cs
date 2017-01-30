using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GladeConstructor
{
    class CreateClassFiles
    {
        private string ClassName, Path;
        private BindingSource Source;
        private GtkParser GladeParser;
        private BindingObject Objects;

        public CreateClassFiles(string classname, string path, GtkParser gladeParser, int bindingSourceId)
        {
            ClassName = classname;
            Path = path;
            GladeParser = gladeParser;
            Source = gladeParser.ObjectBindingSourcesWithoutEmptyId[bindingSourceId];
        }

        private string Tabs(int n)
        {
            return new String('\t', n);
        }

        public void WriteClassFiles()
        {
            WriteHeader();
            WriteCppSource();
        }

        private void WriteHeader()
        {
            using (StreamWriter stream = new StreamWriter(Path + "\\" + ClassName + ".h"))
            {

                stream.WriteLine("/* \n* " + ClassName + ".h \n* \n" +
                                "* Automatically created with BuzzGladeContructor \n" +
                                "* Author: A. Buzz\n" +
                                "* \n*/\n");
                stream.WriteLine("#ifndef _" + ClassName.ToUpper() + "_H_");
                stream.WriteLine("#define _" + ClassName.ToUpper() + "_H_");
                stream.WriteLine("\n#include \"gtkmm.h\"");
                stream.WriteLine();
                stream.WriteLine("class " + ClassName + "{");
                stream.WriteLine("\tpublic:");
                stream.WriteLine(Tabs(2) + ClassName + "()");
                stream.WriteLine(Tabs(2) + ClassName + "(Glib::Dispatcher *dispatcher);");
                stream.WriteLine();
                stream.WriteLine(Tabs(2) + "Glib::Dispatcher *dispatcher;");
                stream.WriteLine(Tabs(2) + "GtkWindow *window;");
                stream.WriteLine(Tabs(2) + "void Close();\n\t\tvoid Show();\n");

                // PRIVATE METHODS
                stream.WriteLine(Tabs(1) + "private:");

                stream.WriteLine(Tabs(2) + "void InitComponents();");

                // WIDGETS STRUCT DECLARATION
                stream.WriteLine(Tabs(2) + "struct _widgets {");
                foreach (BindingObject bndObj in Source)
                {
                    stream.WriteLine(Tabs(3) + "Gtk::" + bndObj.ObjectType + " *" + bndObj.ObjectNameInClass + ";");
                }
                stream.WriteLine(Tabs(2) + "} widgets;");
                stream.WriteLine();

                // CALLBACK DECLARATION
                stream.WriteLine(Tabs(2) + "// Signal callbacks");
                foreach (BindingObject bndObj in Source)
                {
                    if (bndObj.Signals.Count > 0)
                    {
                        string[] callbacks_prototype = GladeParser.BuildHeaderCallback(bndObj);
                        string callbacks = String.Join("\n" + Tabs(2), callbacks_prototype);
                        stream.WriteLine(Tabs(2) + callbacks);
                    }
                }

                // END OF CLASS
                stream.WriteLine("};");
                stream.WriteLine();
                stream.WriteLine("#endif /* _" + ClassName.ToUpper() + "_H_");

            }
        }

        private void WriteCppSource()
        {
            string ClassRef = ClassName + "::";
            using (StreamWriter stream = new StreamWriter(Path + "\\" + ClassName + ".cpp"))
            {

                stream.WriteLine("/* \n* " + ClassName + ".cpp \n* \n" +
                                "* Automatically created with BuzzGladeContructor \n" +
                                "* Author: A. Buzz\n" +
                                "* \n*/\n\n");
                
                stream.WriteLine("#include \""+ClassName+".h\"");
                stream.WriteLine();

                // CONSTRUCTORS
                stream.WriteLine(ClassRef + ClassName + "() {");
                stream.WriteLine(Tabs(1) + "InitComponents();");
                stream.WriteLine("}");

                stream.WriteLine(ClassRef + ClassName + "(Glib::Dispatcher *dispatcher) {");
                stream.WriteLine(Tabs(1) + "this->dispatcher = dispatcher;");
                stream.WriteLine(Tabs(1) + "InitComponents();");
                stream.WriteLine("}");

                // --- START INIT COMPONENTS ---
                stream.WriteLine("void " + ClassRef + "InitComponents() {");
                // Building Components
                stream.WriteLine(Tabs(1) + "builder->get_widget(\"" + ClassName + "\", window);");
                foreach (BindingObject bndObj in Source)
                {
                    stream.WriteLine(Tabs(1) + "builder->get_widget(\"" + bndObj.ObjectId + "\", widgets." + bndObj.ObjectNameInClass + ");");
                }
                

                // Linking Signal
                foreach (BindingObject bndObj in Source)
                {
                    foreach (BindingObject.SignalStruct signal in bndObj.Signals)
                    {
                        string gtkmm_method = GladeParser.ExtractGtkmmSignalMethod(signal.type);
                        stream.WriteLine(Tabs(1) + "widgets." + bndObj.ObjectNameInClass + "->" + gtkmm_method + "().connect(sigc::mem_fun(this,&" + ClassRef + signal.callback + "));");
                    }
                }

                stream.WriteLine(Tabs(1) + "Show();");
                stream.WriteLine("}");
                // --- FINISH INIT COMPONENT ---



                // END OF CLASS

            }
        }
    }
}
