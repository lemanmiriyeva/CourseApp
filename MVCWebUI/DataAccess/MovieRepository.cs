using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCWebUI.Models.Entity;

namespace MVCWebUI.DataAccess
{
    public static class MovieRepository
    {
        private static readonly List<Movie> _movies;

        static MovieRepository()
        {
            _movies=new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    ShortDescription = "Shazam",
                    Name = "Shazam",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ImageUrl = "1.jpg",
                    CategoryId = 1
                },
                new Movie()
                {
                    Id = 2,
                    ShortDescription = "Amazing Grace",
                    Name = "Amazing Grace",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ImageUrl = "5.jpg",
                    CategoryId = 2
                },
                new Movie()
                {
                    Id = 3,
                    ShortDescription = "High Life",
                    Name = "High Life",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ImageUrl = "3.jpg",
                    CategoryId = 3
                },
                new Movie()
                {
                    Id = 4,
                    ShortDescription = "BillBoard",
                    Name = "BillBoard",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ImageUrl = "2.jpg",
                    CategoryId = 4
                },
                new Movie()
                {
                    Id = 5,
                    ShortDescription = "Storm Boy",
                    Name = "Storm Boy",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ImageUrl = "4.jpg",
                    CategoryId = 5
                }
            };
        }
        public static List<Movie> GetList()
        {
            return _movies;
        }

        public static void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.Id == id);
        }
    }
}
