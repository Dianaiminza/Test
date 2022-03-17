using System.Collections.Generic;

namespace Vidly.Models
{
    public class BooksLookupService
    {
        public List<string> GetGenres()
        {
            return new List<string>()
        {
            "Fiction",
            "Thriller",
            "Comedy",
            "Autobiography"
        };
        }
    }
}
