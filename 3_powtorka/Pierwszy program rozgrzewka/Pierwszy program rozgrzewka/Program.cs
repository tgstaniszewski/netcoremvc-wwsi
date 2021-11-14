using System;
using System.Collections.Generic;
using System.Linq;

namespace Pierwszy_program_rozgrzewka
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1,2

            //Console.WriteLine("Podaj swoje imię:");
            //var name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //zadanie 3
            //int result = 5 + 9;



            ////////////OPERATORY////////////////
            //Zadanie 1
            //int number = 3;
            //float money = 13.5f;
            //string text = "przykładowy tekst";
            //bool isLogged = true;
            //char myChar = 'K';
            //decimal price = 13.4m;

            //Console.WriteLine($"zmienna Typu int Wynosi: {number}");
            //Console.WriteLine($"zmienna Typu float Wynosi: {money}");
            //Console.WriteLine($"zmienna Typu string Wynosi: {text}");
            //Console.WriteLine($"zmienna Typu bool Wynosi: {isLogged}");
            //Console.WriteLine($"zmienna Typu char Wynosi: {myChar}");
            //Console.WriteLine($"zmienna Typu decimal Wynosi: {price}");

            //Zadanie2

            //string myAge = "Age:";
            //int wifeAge = 18;
            //var result = myAge + wifeAge;

            //Console.WriteLine(result);

            //wnioski: zmienna wifeAge została automatycznie rzutowana na zmienna typu string w efekcie wyswietlona zostanie suma dwóch zmienny typu string czyli  tekst "Age:18"

            //Zadanie 3

            //bool isTrue = true;
            //bool isFalse = false;
            //bool isReallyTrue = true;

            //var and = isTrue && isFalse;
            //var or = isTrue || isReallyTrue;
            //var negative = !isFalse;

            //Console.WriteLine(and);
            //Console.WriteLine(or);
            //Console.WriteLine(negative);

            //Zadanie 4

            //var a = 5;
            //var b = 12;

            //var add = a + b;
            //var sub = a - b;
            //var div = a/b;
            //var mul = a * b;
            //var mod = a % b;

            //Console.WriteLine(add);
            //Console.WriteLine(sub);
            //Console.WriteLine(div);
            //Console.WriteLine(mul);
            //Console.WriteLine(mod);


            //Zadanie 5

            //string a = "Ala ";
            //string b = "ma ";
            //string c = "kota.";

            //string result = a + b + c;
            //Console.WriteLine(result);

            ////Wnioski: zmienna result wyswietla sume trzech zmiennych typu string.



            //INSTRUKCJE STERUJĄCE I PĘTLE

            //Zadanie 1

            //int n1 = 10;
            //int n2 = 20;

            //if (n1>n2)
            //{
            //    Console.WriteLine("n1 jest wieksze od n2");
            //}
            //else if (n1 == n2)
            //{
            //    Console.WriteLine("n1 jest równe n2");
            //}
            //else
            //{
            //    Console.WriteLine("n1 jest miejsze od n2");
            //}


            //Zadanie 2

            //for (int i = 0; i <10 ; i++)
            //{
            //    Console.WriteLine("C#");

            //}
            //var n = 0;
            //while (n<10)
            //{
            //    Console.WriteLine("C#");
            //    n++;
            //}

            //Zadanie 3

            //var n = 20;
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.Write($"{i} - ");
            //    if (i%2 == 0)
            //    {
            //        Console.Write($"Parzysta\n");

            //    }
            //    else
            //    {
            //        Console.Write("Nieparzysta\n");
            //    }
            //}

            //Zadanie 4

            //var n = 3;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.Write("\n");
            //}

            //Zadanie 5 (dodatkowe)

            //var exam = 57;

            //if (exam >= 0 && exam <=100)
            //{
            //    if (exam <= 39 )
            //    {
            //        Console.WriteLine("Ocena Niedostateczna");
            //    }
            //    else if (exam <= 54)
            //    {
            //        Console.WriteLine("Ocena Dopuszczająca");
            //    }
            //    else if (exam <= 69)
            //    {
            //        Console.WriteLine("Ocena Dostateczna");
            //    }
            //    else if (exam <= 84)
            //    {
            //        Console.WriteLine("Ocena Dobra");
            //    }
            //    else if (exam <= 98)
            //    {
            //        Console.WriteLine("Ocena Bardzo Dobra");
            //    }
            //    else if (exam <= 100)
            //    {
            //        Console.WriteLine("Ocena Celująca");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wartość poza zakresem");
            //}




            //KOLEKCJE

            //Zadanie 1

            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "blue";
            //colors[2] = "green";
            //colors[3] = "black";

            //Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}");
            //Console.WriteLine($"Mój ostatni kolor to: {colors[3]}");

            //Zadanie 2

            int[] number = new int[10] { 0, 1, 2, 7, 4, 6, 9, 6, 11, 77 };

            //for (int i = 0; i < number.Length; i++)
            //{

            //    Console.WriteLine($"Liczba: {number[i]} ");
            //}

            //foreach (var item in number)
            //{
            //    Console.WriteLine($"Liczba: {item} ");
            //}

            //int i = 0;            
            //while (i <number.Length)
            //{
            //    Console.WriteLine($"Liczba: {number[i]}");               
            //    i++;
            //}

            //Zadanie 3

            //List<string> fruits = new List<string>();
            //fruits.Add("Jabłko");
            //fruits.Add("Gruszka");
            //fruits.Add("Śliwka");
            //fruits.Add("Banan");

            //foreach (var item in fruits)
            //{
            //    var a = item + ", ";
            //    if (item == fruits.Last())
            //    {
            //        Console.WriteLine(a.Replace(", ", ""));
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{a}");

            //    }
            //}



            Console.ReadKey();
        }
    }
}
