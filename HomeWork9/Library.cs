public class Library : Organization
{
    public int BooksCount { get; set; }
    public Library(string name, string address, int booksCount) : base(name, address)
    {
        BooksCount = booksCount;
    }
    public override string GetInfo()
    {
        return base.GetInfo() + $", Количество книг: {BooksCount}";
    }
}