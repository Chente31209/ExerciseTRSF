using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace mvc_Migration.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app) 
        {
            EmailContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<EmailContext>();

                 if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }
            if (!context.Emails.Any()) {
                context.Emails.AddRange(
                    new Email{ E_mailDirtetion= "kjbfdgz@vhneouh.com" ,Pasword="ljagn",Id=1,Id_user=1,Id_permissions=100},
                    new Email{E_mailDirtetion= "jkgabpo@vhneouh.com" ,Pasword="ojr ngea",Id=10,Id_user=2,Id_permissions=110},
                    new Email{E_mailDirtetion= "jrrgjmpi@vhneouh.com" ,Pasword="lsotkrhnow",Id=16,Id_user=3,Id_permissions=111},
                    new Email{E_mailDirtetion= "jrh79@vhneouh.com" ,Pasword="lsotk6u0rhnow",Id=18,Id_user=4,Id_permissions=001},
                    new Email{E_mailDirtetion= "pretis0j9@vhneouh.com" ,Pasword="wjsrtyu.ry",Id=54,Id_user=5,Id_permissions=101}
                );
                context.SaveChanges();
            }
        }
    }
}
