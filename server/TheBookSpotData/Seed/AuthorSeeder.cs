using TheBookSpotDomain.Entities;

namespace TheBookSpotData.Seed
{
    internal static class AuthorSeeder
    {
        public static List<Author> Seed()
        {
            List<Author> authors = new();

            using (var reader = new StreamReader(@"..\TheBookSpotData\Seed\AUTHORS_DATA.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    authors.Add(
                        new Author
                        {
                            Id = Guid.NewGuid(),
                            FirstName = values[0].Trim(),
                            LastName = values[1].Trim()
                        }
                    );

                }
            }

            return authors;
        }
    }
}
