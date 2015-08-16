using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotesApp.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}