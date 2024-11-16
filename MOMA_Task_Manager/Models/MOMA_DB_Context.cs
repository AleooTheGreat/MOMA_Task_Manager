using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MOMA.Models;

namespace MOMA.Models
{
    public class MOMA_Db_Context : IdentityDbContext
    {
        public MOMA_Db_Context(DbContextOptions<MOMA_Db_Context> options) : base(options)
        {
        }
        public DbSet<Utilizatori> Utilizatoris { get; set; }    //retardism
        public DbSet<Taskuri> Taskuris { get; set; }    //retardism
        public DbSet<Sclavi> Sclavis { get; set; }  //retardism
        public DbSet<Proiecte> Proiectes { get; set; }  //retardism
    }
}
