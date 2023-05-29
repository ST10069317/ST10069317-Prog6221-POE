using ST10069317_Paballo_Ranoto_;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using static System.Formats.Asn1.AsnWriter;
using System.Security.Cryptography.X509Certificates;

public delegate void myDelegate(int i);

public class Program
{
    public static myDelegate del { get;private set; }
    public static void Main(string[] args)
    {
        Logic logic = new Logic();
        myDelegate del1 = new myDelegate(methodSum);
        //myDelegate del2 = new myDelegate(myObject.checkLImit);
        myDelegate del2 = new myDelegate(methodSum);

        try
        {
            del2.Invoke(301);
        }
        catch(ArgumentOutOfRangeException ex) 
        {
            Console.WriteLine(ex.Message);
        }

        static void methodSum(int i)
        {
            Console.WriteLine((i + 1));
        }
        while (true)
        {
            Console.WriteLine("Welcome to Ingredients Note");
            Console.WriteLine("===================================");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Show");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("===================================");
            Console.WriteLine("Choose an option");
            int respond = Convert.ToInt32(Console.ReadLine());

            switch (respond)
            {
                case 1:
                    logic.Add();
                    break;

                case 2:
                    logic.show();
                    break;

                case 3:
                    logic.Scale();
                    break;

                case 4:
                    logic.Reset();
                    break;

                case 5:
                    logic.Clear();
                    break;

                case 6:
                    Console.WriteLine("Good bye");
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}