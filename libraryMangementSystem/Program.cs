
using libraryMangementSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("_-_-_-_-_-_-_# welcom you in library system..(: #_-_-_-_-_-_-_ ");
        libraray libraray = new libraray();
        while (true)
        {
            Console.WriteLine("plz enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("are you librarian or reguler user..?");
            Console.WriteLine(" 1 => librarian!");
            Console.WriteLine(" 2 => reguler user!");
            Console.WriteLine(" 0 => Exit!");

            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {

                while (true)
                {
                    librarian libn = new librarian();
                    Console.WriteLine($"~~~~~~~~ Welcome librarian {name} ~~~~~~~~");
                    Console.WriteLine(" 1 => Add book!");
                    Console.WriteLine(" 2 => Remove book!");
                    Console.WriteLine(" 3 => Display book!");
                    Console.WriteLine(" 0 => Exit!");
                    Console.WriteLine("plz enter process number..!");
                    int choiceNum = int.Parse(Console.ReadLine());

                    if (choiceNum == 0)
                        break;

                    switch (choiceNum)
                    {
                        case 1:
                            Console.WriteLine("plz enter the book ditils to adding");
                            string name_book = Console.ReadLine();
                            string name_author = Console.ReadLine();
                            int y = int.Parse(Console.ReadLine());

                            Book book = new Book()
                            {
                                Title = name_book,
                                Author = name_author,
                                year = y,
                            };

                            libn.Add(book, libraray);

                            break;
                        case 2:
                            Console.WriteLine("plz enter the book ditils to removing ");
                            name_book = Console.ReadLine();
                            name_author = Console.ReadLine();
                            y = int.Parse(Console.ReadLine());

                            Book book2 = new Book()
                            {
                                Title = name_book,
                                Author = name_author,
                                year = y,
                            };

                            libn.Remove(book2, libraray);

                            break;
                        case 3:
                            Console.WriteLine("------> book list <-------");
                            libn.display(libraray);
                            break;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
            }
            else if (num == 2)
            {
                while (true)
                {
                    RegulerUser lu = new RegulerUser();
                    Console.WriteLine($"~~~~~~~~ Welcome user {name} ~~~~~~~~");
                    Console.WriteLine(" 1 => borroow book!");
                    Console.WriteLine(" 2 => Display book!");
                    Console.WriteLine(" 0 => Exit!");
                    Console.WriteLine("plz enter process number..!");
                    int choiceNumber = int.Parse(Console.ReadLine());

                    if (choiceNumber == 0)
                        break;

                    switch (choiceNumber)
                    {
                        case 1:
                            Console.WriteLine("plz enter the book ditils to adding to borrow");
                            string name_book = Console.ReadLine();
                            string name_author = Console.ReadLine();
                            int y = int.Parse(Console.ReadLine());

                            Book book = new Book()
                            {
                                Title = name_book,
                                Author = name_author,
                                year = y,
                            };

                            lu.borrow(book, libraray);
                            break;
                        case 2:
                            Console.WriteLine("------> book list <-------");
                            lu.display(libraray);
                            break;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
            }
            else if(num == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("invalid choice..!");
            }

        }   


    }
}