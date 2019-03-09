using BusinessRepository;
using BusinessRepository.EmpRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleAppsDegreeVersions
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            var strConnectionName = configuration["ConnectionString"];
            var serviceProvider = new ServiceCollection()
            .AddDbContext<AppDbContext>(option => option.UseSqlServer(strConnectionName))
            .AddSingleton<IUnitOfWork, UnitOfWork>()
            .BuildServiceProvider();
            //Adding changes by Palak
            var emp = serviceProvider.GetService<IUnitOfWork>();

           
            //Paritosh
            //Adding new changes & features
            Console.WriteLine("Hello World!");
        }
    }
}
