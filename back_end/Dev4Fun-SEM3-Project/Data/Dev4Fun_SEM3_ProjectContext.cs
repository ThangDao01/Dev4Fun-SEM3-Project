#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dev4Fun_SEM3_Project.Models;

namespace Dev4Fun_SEM3_Project.Data
{
    public class Dev4Fun_SEM3_ProjectContext : DbContext
    {
        public Dev4Fun_SEM3_ProjectContext (DbContextOptions<Dev4Fun_SEM3_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Dev4Fun_SEM3_Project.Models.Vacancies> Vacancies { get; set; }

        public DbSet<Dev4Fun_SEM3_Project.Models.Applicants> Applicants { get; set; }

        public DbSet<Dev4Fun_SEM3_Project.Models.ApplicantVacancy> ApplicantVacancy { get; set; }

        public DbSet<Dev4Fun_SEM3_Project.Models.Departments> Departments { get; set; }

        public DbSet<Dev4Fun_SEM3_Project.Models.Users> Users { get; set; }
    }
}
