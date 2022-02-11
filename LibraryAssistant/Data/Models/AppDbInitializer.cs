using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace LibraryAssistant.Data.Models
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        ISBN = 123,
                        Status = true,
                        Title = "Merlin",
                        CoverPrice = 2000,
                        PublishYear = 2012
                    },
                    new Book()
                    {
                        ISBN = 124,
                        Status = false,
                        Title = "Arthur",
                        CoverPrice = 3000,
                        PublishYear = 2012
                    },
                    new Book()
                    {
                        ISBN = 125,
                        Status = true,
                        Title = "Lancelot",
                        CoverPrice = 4000,
                        PublishYear = 2012
                    },
                    new Book()
                    {
                        ISBN = 126,
                        Status = true,
                        Title = "Gwen",
                        CoverPrice = 5000,
                        PublishYear = 2012
                    },
                    new Book()
                    {
                        ISBN = 127,
                        Status = true,
                        Title = "Uther",
                        CoverPrice = 6000,
                        PublishYear = 2012
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
