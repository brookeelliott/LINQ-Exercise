using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var MovieNames = new List<string>() { "Die Hard", "James Bond", "Hot Fuzz", "Harry Potter" };

            var SortedMovieNames = MovieNames.OrderBy(size => size.Length).ToList();

            foreach (var i in SortedMovieNames)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
