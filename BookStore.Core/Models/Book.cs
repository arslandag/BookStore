namespace BookStore.Core.Models
{
    public class Book
    {
        public const int MAX_TITLE_LENGTH = 250;

        private Book(Guid id, string title, string description, decimal price)
        {

        }

        public Guid Id { get; }
        public string Title {get; } = string.Empty;
        public string Description { get;} = string.Empty;
        public decimal Price { get; }

        public static (Book Book, string Error) Create(Guid id, string title, string description, decimal price)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
            {
                error = "Title can not be empy or longer then 250 symbol";
            }

            var book = new Book(id, title, description, price);

            return (book, error);
        }
    }
}
