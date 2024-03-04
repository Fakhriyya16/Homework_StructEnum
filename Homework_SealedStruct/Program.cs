using Homework_SealedStruct;

Book book = new Book();

book.Name = "Name1";

//Console.WriteLine(book.Name);

Class1 class1 = new Class1();
class1.MyProperty = 1;

//Console.WriteLine(class1.MyProperty);

//Console.WriteLine(book.Id);

//int? num = null;

//if(book.Id == null)
//{
//    Console.WriteLine("book not found");
//}

Book book1 = new Book()
{
    Id = 1,
    Name = "Name1",
    Author = new Author() { Name = "AuthorName" , Id = 2 },
};
Book book2 = new Book()
{
    Id = 2,
    Name = "Name2"
};

//Console.WriteLine(book1.Name + " " + book1.Author?.Name);

//Console.WriteLine(book2.Name + " " + book2.Author?.Name);

//Book[] books = {book1, book2};

//void GetBookById(Book[] books,int? id = null)
//{
//    if(id == null)
//    {
//        Console.WriteLine("Your id is null");
//        return;
//    }
//    var result = books.FirstOrDefault(x => x.Id == id);

//    Console.WriteLine(result.Name);
//}

//GetBookById(books,1);


//Level level = Level.Low;

//Console.WriteLine((int)level == 1);

void GetLevel(string level)
{
    switch (level)
    {
        case nameof(Level.Low):
            Console.WriteLine("Low");
            break;
        case nameof(Level.Medium):
            Console.WriteLine("Medium");
            break;
        case nameof(Level.High):
            Console.WriteLine("High");
            break;
        default:
            Console.WriteLine("--------");
            break;
    }
}

GetLevel("fdqec");