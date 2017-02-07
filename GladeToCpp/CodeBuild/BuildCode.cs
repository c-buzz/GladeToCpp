using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GladeConstructor.Parser;
using System.Windows.Forms;

namespace GladeConstructor.CodeBuild
{
    class BuildCode
    {
        
        public BuildCode()
        {
            
        }

        public void Process()
        {
            string path = Application.StartupPath + "\\src\\";
            System.IO.Directory.CreateDirectory(path);
            BuildHeaders buildHeaders = new BuildHeaders(path);
            BuildSource buildSource = new BuildSource(path);
            buildHeaders.ProcessHeaders();
            buildSource.ProcessSources();
        }
    }
}
