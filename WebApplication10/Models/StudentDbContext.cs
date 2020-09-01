using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class StudentDbContext:DbContext
    {
       public StudentDbContext():base("sdbcontext")
        {

        }
      public DbSet<Student> Students { get; set; }
    }
}