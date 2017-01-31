using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladeConstructor
{
    class BindingObject
    {
        private string objectId;
        private string objectType;
        private string objectNameInClass;
        private bool addToClass;

        
        public BindingObject(string objId, string objType, string objNIC, bool objATC)
        {
            objectId = objId;
            objectType = objType;
            objectNameInClass = objNIC;
            addToClass = objATC;
        }

        public string ObjectId
        {
            get
            {
                return objectId;
            }
            set
            {
                objectId = value;
            }
        }

        public string ObjectType
        {
            get
            {
                return objectType;
            }
            set
            {
                objectType = value;
            }
        }

        public string ObjectNameInClass
        {
            get
            {
                return objectNameInClass;
            }
            set
            {
                objectNameInClass = value;
            }
        }

        public bool AddObjectToClass
        {
            get
            {
                return addToClass;
            }
            set
            {
                addToClass = value;
            }
        }

    }
}
