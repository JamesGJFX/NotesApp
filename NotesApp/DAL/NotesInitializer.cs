using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NotesApp.Models;

namespace NotesApp.DAL
{
    public class NotesInitializer : DropCreateDatabaseIfModelChanges<NotesContext>
    {
        protected override void Seed(NotesContext context)
        {
            var notes = new List<Note>
            {
                new Note { NoteBody = "This is a note Body 12" },
                new Note { NoteBody = "This is a note Body 13" },
                new Note { NoteBody = "This is a note Body 14" },
                new Note { NoteBody = "This is a note Body 15" },
                new Note { NoteBody = "This is a note Body 16" },
                new Note { NoteBody = "This is a note Body 17" },
                new Note { NoteBody = "This is a note Body 18" },
                new Note { NoteBody = "This is a note Body 19" },
                new Note { NoteBody = "This is a note Body 10" },
            };

            notes.ForEach(n => context.Notes.Add(n));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
                new Subject { SubjectName = "How To Create Notes" , Notes = notes}
            };

            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
        }
    }
}