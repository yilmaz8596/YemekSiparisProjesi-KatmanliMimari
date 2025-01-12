using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess
{
    public class ApplicationDBContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    {
        public ApplicationDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            optionsBuilder.UseSqlServer(
                @"Data Source=DESKTOP-OJQ7MOU\SQLEXPRESS;
                  Initial Catalog=KatmanlıMimari_YemekSiprais;
                  Integrated Security=True;
                  Connect Timeout=30;
                  Encrypt=False;
                  Trust Server Certificate=True;
                  Application Intent=ReadWrite;
                  Multi Subnet Failover=False"
            );

            return new ApplicationDBContext(optionsBuilder.Options);
        }
    }
}