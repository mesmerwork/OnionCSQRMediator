using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionTemplateEx.Application.Interfaces.Repositories.Country;
using OnionTemplateEx.Application.Interfaces.Repositories.Customer;
using OnionTemplateEx.Application.Interfaces.Repositories.Employee;
using OnionTemplateEx.Application.Interfaces.Repositories.Office;
using OnionTemplateEx.Application.Interfaces.Repositories.Payment;
using OnionTemplateEx.Application.Interfaces.Repositories.User;
using OnionTemplateEx.Persistance.Contexts;
using OnionTemplateEx.Persistance.Repositories.Country;
using OnionTemplateEx.Persistance.Repositories.Customer;
using OnionTemplateEx.Persistance.Repositories.Employee;
using OnionTemplateEx.Persistance.Repositories.Office;
using OnionTemplateEx.Persistance.Repositories.Payment;
using OnionTemplateEx.Persistance.Repositories.User;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Persistance
{
    public static class ServicesRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
           
            services.AddDbContext<OnionTemplateExDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IReadCountryRepository, ReadCountryRepository>();
            services.AddScoped<IWriteCountryRepository, WriteCountryRepository>();

            services.AddScoped<IReadCustomerRepository, ReadCustomerRepository>();
            services.AddScoped<IWriteCustomerRepository, WriteCustomerRepository>();

            services.AddScoped<IReadEmployeeRepository, ReadEmployeeRepository>();
            services.AddScoped<IWriteEmployeeRepository, WriteEmployeeRepository>();

            services.AddScoped<IReadOfficeRepository, ReadOfficeRepository>();
            services.AddScoped<IWriteOfficeRepository, WriteOfficeRepository>();

            services.AddScoped<IReadPaymentRepository, ReadPaymentRepository>();
            services.AddScoped<IWritePaymentRepository, WritePaymentRepository>();

            services.AddScoped<IReadUserRepository, ReadUserRepository>();
            services.AddScoped<IWriteUserRepository, WriteUserRepository>();
        }
    }
}
