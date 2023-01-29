using Microsoft.EntityFrameworkCore;
using WebApi_InMemoryDb.Model;

namespace WebApi_InMemoryDb.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { id = 1, title = "The Shawshank Redemption", rating = "9,3", genre = "Crime", duration = 142 },
                new Movie { id = 2, title = "The Godfather", rating = "9,2", genre = "Crime", duration = 175 },
                new Movie { id = 3, title = "The Godfather: Part II", rating = "9,1", genre = "Crime", duration = 200 },
                new Movie { id = 4, title = "The Dark Knight", rating = "9", genre = "Action", duration = 152 },
                new Movie { id = 5, title = "Pulp Fiction", rating = "8,9", genre = "Crime", duration = 154 },
                new Movie { id = 6, title = "12 Angry Men", rating = "8,9", genre = "Drama", duration = 96 },
                new Movie { id = 7, title = "The Good, the Bad and the Ugly", rating = "8,9", genre = "Western", duration = 161 },
                new Movie { id = 8, title = "The Lord of the Rings: The Return of the King", rating = "8,9", genre = "Adventure", duration = 201 },
                new Movie { id = 9, title = "Schindler's List", rating = "8,9", genre = "Biography", duration = 195 },
                new Movie { id = 10, title = "Fight Club", rating = "8,9", genre = "Drama", duration = 139 },
                new Movie { id = 11, title = "The Lord of the Rings: The Fellowship of the Ring", rating = "8,8", genre = "Adventure", duration = 178 },
                new Movie { id = 12, title = "Inception", rating = "8,8", genre = "Action", duration = 148 },
                new Movie { id = 13, title = "Star Wars: Episode V - The Empire Strikes Back", rating = "8,8", genre = "Action", duration = 124 },
                new Movie { id = 14, title = "Forrest Gump", rating = "8,8", genre = "Drama", duration = 142 },
                new Movie { id = 15, title = "The Lord of the Rings: The Two Towers", rating = "8,8", genre = "Adventure", duration = 179 });
        }
}
}
