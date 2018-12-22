using Microsoft.EntityFrameworkCore;
using NoteTaker.Models;

namespace NoteTaker.Data
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=note-taker.db");
        }
    }
}
