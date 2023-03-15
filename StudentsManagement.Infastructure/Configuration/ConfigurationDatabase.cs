using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentsManagement.DataAcces.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Infastructure.Configuration
{
    public static class ConfigurationDatabase
    {
       
            public static void ConfigDatabase( this IServiceCollection service, IConfiguration configuration)
            {
                service.AddDbContext<StudentsManagementDBContext>(
                options => options
                .UseSqlServer(configuration.GetConnectionString("StudentManagement"),
                b => b.MigrationsAssembly("StudentsManagement.DataAccess")));
            }

        
  }
}
