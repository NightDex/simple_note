using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_note
{
    public class NoteText
    {
        string note_text;

        public NoteText(string note_text)
        {
            this.note_text = note_text;
        }

        public override string ToString()
        {
            return $"{this.note_text}";
        }
    }
}
