using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public struct File : IComparable<File>
    {
        public string name;
        public string extension;
        public string size;
        public string dateOfChange;
        public string timeOfChange;
        public File(string name, string extension, string size, string dateOfChange, string timeOfChange)
        {
            this.name = name;
            this.extension = extension;
            this.size = size;
            this.dateOfChange = dateOfChange;
            this.timeOfChange = timeOfChange;
        }

        public int CompareTo(File other) 
        {
            return name.CompareTo(other.name);
        }
    }

}
