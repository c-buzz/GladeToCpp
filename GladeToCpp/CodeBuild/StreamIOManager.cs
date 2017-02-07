using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladeConstructor.CodeBuild
{
    class StreamIOManager
    {
        public Stream CodeStream { get; set; }

        public StreamIOManager(Stream stream)
        {
            CodeStream = stream;
        }

        public void SetStreamPosition(long position)
        {
            CodeStream.Position = position;
        }

        // They returns the position of the appended text

        public long WriteListOfStringIntoStream(List<string> list, bool update_buffer_position = true)
        {
            // Merge the list in a single string separated by a new line \n
            string text = String.Join<string>("\n", list) + "\n";

            return WriteTextIntoStream(text);
        }

        public long WriteListOfStringIntoStream(List<string> list, long position, bool update_buffer_position = true)
        {
            SetStreamPosition(position);
            return WriteListOfStringIntoStream(list, update_buffer_position);
        }


        public long WriteTextIntoStream(string text)
        {
            return WriteByteArrayIntoStream(Encoding.ASCII.GetBytes(text));
        }

        public long WriteTextIntoStream(string text, long position)
        {
            SetStreamPosition(position);
            return WriteByteArrayIntoStream(Encoding.ASCII.GetBytes(text));
        }

        public long WriteByteArrayIntoStream(byte[] buffer)
        {
            // Save current buffer position
            long current_position = CodeStream.Position;

            // NB: Writing the bytes from the CurrentBufferPosition will cause the replacing of
            //      subsequent data. We copy the rest of the stream and append it to the end of the text written
            Stream copystream = new MemoryStream();
            CodeStream.CopyTo(copystream);

            // Refresh the position of the stream
            CodeStream.Position = current_position;

            // Write the byte array buffer into the stream
            CodeStream.Write(buffer, 0, buffer.Length);

            current_position = CodeStream.Position;

            // Reset the position of the temporary stream
            copystream.Position = 0;

            // Restore HeaderFileStream
            copystream.CopyTo(CodeStream);

            // Put the position back to the text inserted
            CodeStream.Position = current_position;

            return current_position;
        }

        public long WriteByteArrayIntoStream(byte[] buffer, long position)
        {
            SetStreamPosition(position);
            return WriteByteArrayIntoStream(buffer);
        }

        public void StreamToFile(string filename)
        {
            FileStream fs = File.Create(filename);
            CodeStream.Position = 0;
            CodeStream.CopyTo(fs);
            fs.Close();
        }
    }
}
