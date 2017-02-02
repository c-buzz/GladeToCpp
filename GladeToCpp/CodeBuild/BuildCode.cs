using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GladeConstructor.GladeParser;
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
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\\src\\");
            BuildHeaders buildHeaders = new BuildHeaders(Application.StartupPath + "\\src\\");
            buildHeaders.ProcessHeaders();
        }
    }
}
