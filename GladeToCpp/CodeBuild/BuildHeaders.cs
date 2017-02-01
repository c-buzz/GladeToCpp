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
        Stream HeaderFileStream = new MemoryStream();
        long CurrentBufferPosition = 0;

        public BuildHeaders()
        {
            BindingForm form = (BindingForm) GuiManager.Parser.FormBindingSources[0];
            WriteHead(form.Class);

            TestAddString();

            WriteHeaderStreamToFile(form.Class + ".h");
        }

        private void TestAddString()
        {
            string[] args = { "int a", "string b" };
            string test = "\t\tvoid first_method(int a, int b); \n" +
                "\t\tvoid second_method(int a, int c); \n" + 
                WritePrototype("int","third_method", args);
            WriteTextIntoHeaderStream(test);
        }

        private string WritePrototype(string type, string method, string[] args, int tabs = 2)
        {
            string output = Utils.Tabs(tabs) + type + " " + method + "(";
            output += String.Join(", ", args) + ");\n";
            return output;
        }

        private void WriteHeaderStreamToFile(string filename)
        {
            FileStream fs = File.Create(filename);
            HeaderFileStream.Position = 0;
            HeaderFileStream.CopyTo(fs);
            fs.Close();
        }

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
            WriteListOfStringIntoHeaderStream(headlist);

            // Point the current position of the buffer to the end of the stream
            CurrentBufferPosition = HeaderFileStream.Position;

            // Continue with the end of the head class
            headlist.Add("};");
            headlist.Add("\n");
            headlist.Add("#endif /* _" + className + "_H_ */");

            // Write the second part of the head class to the HeaderFileStream
            WriteListOfStringIntoHeaderStream(headlist, false);

            // Take back the position of the buffer to the public method of the class
            HeaderFileStream.Position = CurrentBufferPosition;
        }

        private void WriteListOfStringIntoHeaderStream(List<string> list, bool update_buffer_position = true, bool clear_list = true)
        {
            // Merge the list in a single string separated by a new line \n
            string text = String.Join<string>("\n", list);

            // Create byte array from text
            byte[] buffer = Encoding.ASCII.GetBytes(text);

            WriteByteArrayIntoHeaderStream(buffer, update_buffer_position);

            if (clear_list)
            {
                list.Clear();
            }
        }

        private void WriteTextIntoHeaderStream(string text, bool update_buffer_position = true)
        {
            WriteByteArrayIntoHeaderStream(Encoding.ASCII.GetBytes(text), update_buffer_position);
        }

        private void WriteByteArrayIntoHeaderStream(byte[] buffer, bool update_buffer_position = true)
        {
            // Se HeaderFileStream position
            HeaderFileStream.Position = CurrentBufferPosition;

            // NB: Writing the bytes from the CurrentBufferPosition will cause the replacing of
            //      subsequent data. We copy the rest of the stream and append it to the end of the text written
            Stream temp_stream = new MemoryStream();
            HeaderFileStream.CopyTo(temp_stream);

            // Refresh the position of the stream
            HeaderFileStream.Position = CurrentBufferPosition;
            
            // Write the byte array buffer into the stream
            HeaderFileStream.Write(buffer, 0, buffer.Length);

            // Update the CurrentBufferPosition if required
            if (update_buffer_position)
            {
                CurrentBufferPosition = HeaderFileStream.Position;
            }

            // Reset the position of the temporary stream
            temp_stream.Position = 0;

            // Restore HeaderFileStream
            temp_stream.CopyTo(HeaderFileStream);
        }
    }
}
