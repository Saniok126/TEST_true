using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TEST_true.Models
{
    public class Database: DbContext
    {
        public DbSet<post> Posts { get; set; }
        public DbSet<comment> Comments { get; set; }


        public Database(DbContextOptions<Database> options)
           : base(options)
        {

        }
    }
}
