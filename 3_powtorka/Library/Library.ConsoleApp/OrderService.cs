using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.ConsoleApp
{
    public class OrderService
    {
        private OrdersRepository _orderRepository;

        public OrderService(OrdersRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void PlaceOrder()
        {
            var order = new Order();

            var command = "";
            do
            {
                Console.Clear();
                Console.WriteLine("###########ZAMÓWIENIE############");
                Console.WriteLine("add - dodaj pozycje do zamówienia");
                Console.WriteLine("end - zamknij zamówienie");
                Console.WriteLine("Podaj komende:");
                command = Console.ReadLine();
                if (command == "add")
                {
                    Console.WriteLine("Podaj ID ksiazki:");
                    var id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj ilość:");
                    var ilosc = Convert.ToInt32(Console.ReadLine());
                    var bookOrdered = new BookOrdered();
                    bookOrdered.BookId = id;
                    bookOrdered.NumerOrdered = ilosc;

                    order.BooksOrderedList.Add(bookOrdered);
                }
                else if (command == "end")
                {
                    _orderRepository.Insert(order);
                }


            } while (command != "end");

        }


        public void ListAll()
        {
            var all = _orderRepository.GetAll();
            Console.Clear();
            Console.WriteLine("Wszystkie zamówienia:");
            foreach (var item in all)
            {
                item.ToString();
            }
        }

    }
}
