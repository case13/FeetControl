using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace FeetControl.Infrastructure.Data
{
    public class FeetControlDbContextFactory : IDesignTimeDbContextFactory<FeetControlDbContext>
    {
        public FeetControlDbContext CreateDbContext(string[] args)
        {
            var solutionRoot = FindSolutionRoot(Directory.GetCurrentDirectory());

            // Ajuste aqui se seu caminho for diferente
            var apiPath = Path.Combine(solutionRoot, "Backend", "FeetControl.Api");

            if (!Directory.Exists(apiPath))
                throw new DirectoryNotFoundException($"API path not found: {apiPath}");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(apiPath)
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var conn = configuration.GetConnectionString("DefaultConnection")
                       ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            var optionsBuilder = new DbContextOptionsBuilder<FeetControlDbContext>();
            optionsBuilder.UseSqlServer(conn);

            return new FeetControlDbContext(optionsBuilder.Options);
        }

        private static string FindSolutionRoot(string startPath)
        {
            var dir = new DirectoryInfo(startPath);

            while (dir != null)
            {
                // Procura o .sln (melhor forma)
                var sln = dir.GetFiles("*.sln");
                if (sln.Length > 0)
                    return dir.FullName;

                dir = dir.Parent;
            }

            throw new DirectoryNotFoundException("Solution root not found. Run the command inside the solution folder structure.");
        }
    }
}
