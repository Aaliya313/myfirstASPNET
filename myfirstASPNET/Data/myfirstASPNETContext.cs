using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myfirstASPNET.Models;

namespace myfirstASPNET.Data.StudentDb
{
    public class myfirstASPNETContext : DbContext
    {
        public myfirstASPNETContext (DbContextOptions<myfirstASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<myfirstASPNET.Models.Student> Student { get; set; } = default!;
    }
}
