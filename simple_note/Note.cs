using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_note
{
    public class Note
    {
        public string name;

        public Note(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{this.name}";
        }
    }
}
