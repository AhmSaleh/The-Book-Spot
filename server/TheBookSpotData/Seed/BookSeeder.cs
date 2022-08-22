using System.Diagnostics;
using TheBookSpotDomain.BookEnums;
using TheBookSpotDomain.Entities;

namespace TheBookSpotData.Seed
{
    internal class BookSeeder
    {
        public static List<Book> Seed(List<Author> authors)
        {
            List<Book> books = new();
            int counter = 0;

            using (var reader = new StreamReader(@"..\TheBookSpotData\Seed\BOOKS_DATA.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var random = new Random();

                    Debug.WriteLine(counter++);

                    books.Add(
                        new Book
                        {
                            Id = Guid.Parse(values[0]),
                            Title = values[1],
                            Type = (BookType)int.Parse(values[2]),
                            PublicationYear = int.Parse(values[3]),
                            Price = int.Parse(values[4]),
                            Condition = (BookCondition)int.Parse(values[5]),
                            ISBN = values[6],
                            AuthorId = authors[random.Next() % authors.Count].Id
                        }
                    ); ;

                }
            }

            return books;
        }
    }
}
