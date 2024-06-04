using NoteBook.Models;
using Microsoft.EntityFrameworkCore;

namespace NoteBook.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0KSRB41\\SQLEXPRESS;database=DBnotebook;integrated security=true;");
        }
        public DbSet<TblGiris> TblGirises { get; set; }
        public DbSet<TblNotlar> tblNotlars { get; set; }
        public DbSet<TblSifreler> tblSifrelers { get; set; }
        public DbSet<TblAdmin> tblAdmins { get; set; }


    }
}

