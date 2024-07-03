namespace EFcorefirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateGenre(new Genre
            //{
            //    Name = "drama"
            //});

            //Console.WriteLine(GetGenreById(1).Name);

            
        }

        static void CreateGenre(Genre genre)
        {
            Datacontext datacontext = new Datacontext();
            datacontext.Genre.Add(genre);
            datacontext.SaveChanges();
        }
        static Genre GetGenreById(int id)
        {
            Datacontext datacontext = new Datacontext();
            var data = datacontext.Genre.Find(id);
            return data;
        }
        static List<Genre> GetAllGenres()
        {
            Datacontext datacontext = new Datacontext();
            return datacontext.Genre.ToList();
            datacontext.SaveChanges();
        }
        static void UpdateGenre(int id, Genre genre)
        {
            Datacontext datacontext = new Datacontext();
            var wantedgenre = datacontext.Genre.FirstOrDefault(x=>x.Id == id);
            if (wantedgenre != null)
            {
                wantedgenre.Name = genre.Name;
                datacontext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        static void DeleteGenre(int id)
        {
            Datacontext datacontext = new Datacontext();
            Genre? wantedgenre = datacontext.Genre.FirstOrDefault(x => x.Id == id);
            if (wantedgenre == null)
            {
                throw new NullReferenceException();
            }
            datacontext.Genre.Remove(wantedgenre);
            datacontext.SaveChanges();
        }

        //Book 
        static void CreateBook(Book book)
        {
            Datacontext datacontext = new Datacontext();
            datacontext.Books.Add(book);
            datacontext.SaveChanges();
        }
        static Book GetbookById(int id)
        {
            Datacontext datacontext = new Datacontext();
            var data = datacontext.Books.Find(id);
            return data;
        }
        static List<Book> GetAllBooks()
        {
            Datacontext datacontext = new Datacontext();
            return datacontext.Books.ToList();
            datacontext.SaveChanges();
        }
        static void UpdateBook(int id, Book book)
        {
            Datacontext datacontext = new Datacontext();
            var wantedbook = datacontext.Books.FirstOrDefault(x => x.Id == id);
            if (wantedbook != null)
            {
                wantedbook.Name = book.Name;
                datacontext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        static void DeleteBook(int id)
        {
            Datacontext datacontext = new Datacontext();
            Book? wantedbook = datacontext.Books.FirstOrDefault(x => x.Id == id);
            if (wantedbook == null)
            {
                throw new NullReferenceException();
            }
            datacontext.Books.Remove(wantedbook);
            datacontext.SaveChanges();
        }
    }
}
