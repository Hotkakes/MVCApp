using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public static class SeedData
    {
       public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppContext(serviceProvider.GetRequiredService<DbContextOptions<MVCAppContext>>()))
            {
                if(context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters2",
                        ReleaseDate = DateTime.Parse("1986-3-13"),
                        Genre = "Comedy",
                        Price = 9.99M
                    });
                context.SaveChanges();
            }
        }
    }
}
