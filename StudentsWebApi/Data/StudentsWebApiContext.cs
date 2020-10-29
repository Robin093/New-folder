using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentsWebApi.Models
{
    public class StudentsWebApiContext : DbContext
    {
        public StudentsWebApiContext (DbContextOptions<StudentsWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsWebApi.Models.Student> Student { get; set; }
    }
}
