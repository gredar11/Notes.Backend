using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nodes.Application.Interfaces;
using Nodes.Persistance.EntityTypeConfigurations;
using Notes.Domain;

namespace Nodes.Persistance
{
    public class NotesDbContext:DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }
        public NotesDbContext(DbContextOptions<NotesDbContext> options):base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfigurations());
            base.OnModelCreating(builder);
        }
    }
}
