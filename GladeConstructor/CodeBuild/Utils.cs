using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladeConstructor.CodeBuild
{
    class Utils
    {
        public static string Tabs(int tabs)
        {
            return new string('\t', tabs);
        }

        public static string Returns(int n)
        {
            return new string('\n', n);
        }
    }
}
