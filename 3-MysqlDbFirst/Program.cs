using _3_MysqlDbFirst.Model;
using Microsoft.EntityFrameworkCore;

namespace _3_MysqlDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
         SakilaContext context = new SakilaContext();
            var result = context.Films.Include(p => p.FilmActors).ThenInclude(p=>p.Actor).ToList();

            foreach (var film in result)
            {

                Console.WriteLine($"{film.Title}\t{film.Description}");
                foreach (var actor in film.FilmActors)
                {
                    Console.WriteLine($"{actor.Actor.FirstName}\t{actor.Actor.LastName}");

                }
                Console.WriteLine("**************");
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
