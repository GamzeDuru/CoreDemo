using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LHV6GCE ; Database=OnlinePsikologDb; Trusted_Connection=true; integrated security=true; TrustServerCertificate=True;");

        }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Psikolog> Psikologs { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<TelGorusme> TelGorusmes { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Uye> Uyes { get; set; }

    }
}
