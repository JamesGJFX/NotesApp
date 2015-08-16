using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NotesApp.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NotesApp.DAL
{
    public class NotesContext : DbContext
    {
        public NotesContext() : base("NotesContext")
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}