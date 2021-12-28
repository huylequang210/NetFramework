using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BenhNhanContext : DbContext
    {
        public BenhNhanContext() : base("name=BenhNhanContext")
        {


        }

        public DbSet<BenhNhan> BenhNhans { get; set; }
        public DbSet<BenhAn> BenhAns { get; set; }
        public DbSet<Benh> Benhs { get; set; }
    }
}
