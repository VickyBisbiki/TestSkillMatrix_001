using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSkillMatrix_001.Models;

namespace TestSkillMatrix_001.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Employee> Employees { get; set; } 
        public virtual DbSet<Department> Departments { get; set; }

  
    }
}
