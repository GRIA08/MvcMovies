using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using MvcMovie.Data;
using MvcMovies.Data;
using MvcMovies.Models;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMoviesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMoviesContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Minions",
                    ReleaseDate = DateTime.Parse("2015-06-10"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Frozen",
                    ReleaseDate = DateTime.Parse("2013-11-27"),
                    Genre = "Disney",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Lion King",
                    ReleaseDate = DateTime.Parse("1994-06-24"),
                    Genre = "Adventure",
                    Rating = "R",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Zootopia",
                    ReleaseDate = DateTime.Parse("2016-03-04"),
                    Genre = "Animated",
                    Rating = "R",
                    Price = 9.99M
                }

            );
            context.SaveChanges();

            if (context.Movie.Any())
            {
                return;  // DB has been seeded.
            }
        }
    }
}


