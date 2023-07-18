using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void greet(string name)
        {
            Console.WriteLine("Good Morning "  +   name);
        }
        static float Average(int a , int b, int c)
        {
            float sum = a + b+ c;
            return sum / 3;
        }
        static void Main(string[] args)
        {/*
            //this is example  for practice
            you can use this code for practic.
            string inp = Console.ReadLine();
            Console.WriteLine(inp);
            int num = 10;
            Console.WriteLine("Hello Buddy");
            Console.WriteLine("kidan");
            Console.WriteLine("tera bhe sahi ha" + num);
            Console.WriteLine("" + num);
            */



            // Data types examples
            // int a = 33;
            // float b = 33.4F;
            //Double c = 32.33;
            // bool isGreat = false;
            // char d ='f';
            // string e = "mahesh dlle";
            //  Console.WriteLine(a);
            //  Console.WriteLine(b);   
            //  Console.WriteLine(c);
            //  Console.WriteLine(d);
            //  Console.WriteLine(isGreat);
            //  Console.WriteLine(e);



            // Type Casting
            // There are two types of casting


            // 1 Implicit Casting
            // char to int to long to flot to double 
            /* int x = 0;
             double y = x;
             int z = 'y';
             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.WriteLine(z);
            */

            // 2 Explicit casting
            /*
             double q = 3.5;
             int w = (int) q;
             Console.WriteLine(w); 
             Console.WriteLine(q);
          */
            /*
            int x1 = 3;
            double y1 = 4;
            float x2 = 'y';
            float varr = Convert.ToInt32(34.44);
            Console.WriteLine(x1);
            Console.WriteLine(y1);
            Console.WriteLine(varr);
            Console.WriteLine(x2);
            */


            //Console.WriteLine("Enter your name buddy");
            //string Name = Console.ReadLine();
            //Console.WriteLine("hy:" + Name);


            //  Console.WriteLine("how many Lays you want ?");
            //string lays = Console.ReadLine();
            //Console.WriteLine("you won 2 more Lays for free ");
            //Console.WriteLine("Total item odered:" + 
            //                    (Convert.ToInt32(lays) + 2));


            /*
              Operators in C#
            1. Arithmetic Operators
            2. Assignment Operators 
            3. Logical Operators 
            4. Comperison Operators
            */

            //1.Arithmetic Operators
            //int A = 4;
            //int B = 8;
            //Console.WriteLine("The value of A + B " + (A + B));
            //Console.WriteLine("The value of A - B " + (A - B));
            //Console.WriteLine("The value of A * B " + (A * B));
            //Console.WriteLine("The value of A / B " + (A / B));


            //2.Assignment Operators
            //int W = 2;
            //int E = W;
            // W += 2;
            //W -= 2;
            //W *= 2;
            //W /= 2;
            //Console.WriteLine(W);

            //3.Logical Operators
            //And 
            //Console.WriteLine(true && false);
            //Console.WriteLine(false && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && true);
            //OR
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || true);
            //NOT
            //Console.WriteLine(!true);
            //Console.WriteLine(!false);

            //4.Comperison Operators
            //Console.WriteLine(555 > 333);
            //Console.WriteLine(555 < 333);
            //Console.WriteLine(555 <= 333);
            //Console.WriteLine(555 >= 333);
            //Console.WriteLine(555 != 333);

            //int A1 = Math.Max(33 , 44 );
            //int A1 = Math.Min(33 , 44 );
            // double  A1 = Math.Sqrt(33 );
            //double A1 = Math.Abs(34.51 );
            //Console.WriteLine(A1);

            //string hello = "hello guys welcome to my place";

            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());

            //string name = Console.ReadLine();
            //string lays = Console.ReadLine();
            //Console.WriteLine($"you name is{name}. you odered {lays} lays .");


            // string hello = ("hello guys \" welcome to my place");
            //string hello = ("hello guys \t welcome to my place");
            // string hello = ("hello guys \n welcome to my place");
            //Console.WriteLine(hello[7]);
            //Console.WriteLine(hello.IndexOf("welcome"));
            //Console.WriteLine(hello);




            // Console.WriteLine(" Enter your age to apply for DL");
            // string agestr = Console.ReadLine();
            // int age = Convert.ToInt32(agestr);
            //if (age > 18 && age < 70)
            // {
            //     Console.WriteLine("you are eligible for dl");

            // }
            //else if(age < 10)
            // {
            //     Console.WriteLine("you are a kid , drive your cycle");
            // }

            //else
            // {
            //     Console.WriteLine("you canot drive");
            // }





            //int age = 17 ;

            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("Wait for an year to get the drink");
            //        break;

            //    case 19:
            //        Console.WriteLine("you are 19, you can take your drink");
            //        break;



            //    default:
            //            Console.WriteLine("Enjoy your drink!");
            //        break;
            //}



            //Loops in C#
            //1.While Loop
            //int i = 0;
            //while(i<=100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //2. do while
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i>10);

            //3. forloop
            //for (int i = 0; i<5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Break and Continue
            //Break:: leave the for loopp
            //Continue:: leave this perticual itretion of the loop

            //greet("Jatin");

            //Console.WriteLine(Average(6, 6, 6));


            // using Player class import from player.cs
            //player tommy = new player ();
            //Console.WriteLine(tommy.gethealth());
            //tommy.setHealth(57);
            //Console.WriteLine(tommy.gethealth());


            Console.ReadLine();

        }
    }
}
