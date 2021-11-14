using Library.Domain;
using Library.Persistence;
using System;

namespace Library.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter i Zakon Feniksa", "J.K.Rowling", 2016, "232323", 10, 34.53m);
            //Console.WriteLine("Podaj Login: ");
            var login = Console.ReadLine();
            //Console.WriteLine("Podaj Hasło: ");
            var passw = Console.ReadLine();

            passw = "password";
            login = "Admin";

            BooksRepository repository = new BooksRepository();
            BooksService serviceBooks = new BooksService(repository);
            OrdersRepository ordersRepository = new OrdersRepository();
            OrderService orderService = new OrderService(ordersRepository);
            if (login == "Admin" && passw == "password")
            {
                Console.WriteLine("Access Granted");


                var command = "";

                do
                {
                    Console.Clear();
                    Console.WriteLine("DOSTEPNE KOMENDY:");
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("dodaj - dodanie ksiazki");
                    Console.WriteLine("usun - usuniecie ksiazki");
                    Console.WriteLine("wypisz - wypisanie wszystkich ksiązek");
                    Console.WriteLine("zmien - zmiana stanu magazynowego ksiazek");
                    Console.WriteLine("dodaj zamowienie - dodanie nowego zamówienia");
                    Console.WriteLine("lista zamowien - wypisanie wszystkich zamowie");
                    Console.WriteLine("wyjdz - wyjscie z programu");
                    Console.WriteLine(Environment.NewLine);

                    Console.WriteLine("podaj komende: ");
                    command = Console.ReadLine();
                    switch (command)
                    {
                        case "dodaj":
                            serviceBooks.AddBook();
                            break;
                        case "usun":
                            serviceBooks.RemoveBook();
                            break;
                        case "wypisz":
                            serviceBooks.ListBooks();
                            break;
                        case "zmien":
                            serviceBooks.ChangeState();
                            break;
                        case "dodaj zamowienie":
                            orderService.PlaceOrder();
                            break;
                        case "lista zamowien":
                            orderService.ListAll();
                            break;
                        case "wyjdz":
                            Console.WriteLine("zamkniecie programu");
                            break;

                        default:
                            Console.WriteLine("podana komenda nie jest wspierana");
                            break;
                    }
                    Console.WriteLine("Press AnyKey");
                    Console.ReadKey();

                } while (command != "wyjdz");


            }
            else
            {
                Console.WriteLine("Access Denied");
            }

            Console.ReadLine();
        }

    }
}
