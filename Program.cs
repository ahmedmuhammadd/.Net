using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment
{
    public class Program
    {
        static void Main(string[] args)
        {

            //1 - Write a program that allows the user to enter a number then print it.
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);


            //2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            int intStr = Convert.ToInt32(str);
            Console.WriteLine(intStr);  //=> will not print 


            //3-	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            Console.WriteLine("enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);


            //4-	Write C# program that Extract a substring from a given string.
            Console.WriteLine("enter a string");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1.Substring(2, 3));


            //5 - Write C# program that Assigning one value type variable to another and modifying
            //the value of one variable and mention what will happen
            int a = 1;
            int b = a;
            b = 2;
            //b will be 2
            //a will be 1
            Console.WriteLine(a + " " + b);



            //6-Write C# program that Assigning one reference type variable to another and modifying
            //the object through one variable and mention what will happen
            string c = "hello";
            string d = c;
            d = "hi";
            //d will be "hi"
            //c will be "hello"
            Console.WriteLine(c + " " + d);



            //7 - Write C# program that take two string variables and print them as one variable 
            string val1 = "hello";
            string val2 = "hello";
            string val3 = val1 + val2;
            Console.WriteLine(val3);



            //8- Write a program that calculates the simple interest given the principal amount, rate of interest,
            //and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            Console.WriteLine("enter  principal number");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter rate number");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter time number");
            double time = Convert.ToDouble(Console.ReadLine());
            double interest = (principal * rate * time) / 100;
            Console.WriteLine(interest);



            //9-	Write a program that calculates the Body Mass Index (BMI) given a person's
            //weight in kilograms and height in meters. The formula for BMI is  BMI = (Weight) / (Height * Height)

            Console.WriteLine("enter weight number");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter height number");
            double height = Convert.ToDouble(Console.ReadLine());
            double BMI = weight / (height * height);
            Console.WriteLine(BMI);



            //10-	Write a program that uses the ternary operator to check if the temperature is too hottoo cold,
            //or just good. Assign the result in a variable then display the result. Assume that below 
            //10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            Console.WriteLine("enter temperature number");
            double temp = Convert.ToDouble(Console.ReadLine());
            string result = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
            Console.WriteLine(result);



            //11- Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            // Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001
            // Get input from user
            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine($"Today's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} – {month} – {year}");


            //12-	 What is the output of the following C# code?

            //  DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //The event is on 06/14/2024






            //13 - Which of the following statements is correct about the C#.NET code snippet given below?

            /*
              int d;
             d = Convert.ToInt32(!(30 < 20));
             */

            //      ==========>      f)	A value 1 will be assigned to d.







            //14 - Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            //  ==========>          a) 6.5 1






            //15 - What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //            if (!(num <= 0))
            //                Console.WriteLine(++num + z++ + " " + ++z);
            //            else
            //                Console.WriteLine(--num + z-- + " " + --z);
            //=>>>>>>>>>> d) 7 7

        }


    }
}
