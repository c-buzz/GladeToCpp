using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GladeConstructor.Parser;
using System.Xml;

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

        public struct CppVariable
        {
            /// <summary>
            ///     Store the infor of a C++ variable and lets to return its declaration
            /// </summary>
            /// <param name="type">The type of the variable</param>
            /// <param name="name">The name of the variable</param>
            /// <param name="pointer">Establishes if the variable is a pointer or not</param>
            public CppVariable(string type, string name, bool pointer = false)
            {
                this.type = type;
                this.name = name;
                this.is_pointer = pointer;
            }

            public CppVariable(string name, bool pointer = false)
            {
                this.type = "void";
                this.name = name;
                this.is_pointer = pointer;
            }

            public string Declaration(int tabs = 2)
            {
                string output = Tabs(tabs) + Type;
                output += (IsPointer) ? " *" : " ";
                output += Name + ";";
                return output;
            }

            string type;
            public string Type
            {
                get
                {
                    return type;
                }
                set
                {
                    type = value;
                }
            }

            string name;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            bool is_pointer;
            public bool IsPointer
            {
                get
                {
                    return is_pointer;
                }
                set
                {
                    is_pointer = value;
                }
            }


        }
    }
}
