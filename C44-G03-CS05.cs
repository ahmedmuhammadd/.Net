using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            assignment();
            Console.ReadKey();

        }
        public static void assignment()
        {
            //        1 - .Write a program that prints an identity matrix using for loop, in other
            //words takes a value n from the user and shows the identity table of size n *n.

            Console.Write("Enter the size of the identity matrix (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Identity Matrix of size {0}x{0}:", n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }


            //2 - Write a program in C# Sharp to find the sum of all elements of the array.

            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"The sum of all elements of the array is: {sum}");


            //3- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 6, 7, 8, 9, 10 };
            int[] mergedArray = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                mergedArray[i] += arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                mergedArray[i + arr1.Length] += arr2[i];
            }
            foreach (var item in mergedArray)
            {
                Console.WriteLine(item);
            }

            //4 - Write a program in C# Sharp to find maximum and minimum element in an
            //array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };

            int[] arr3 = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };
            Console.WriteLine("Max and Min of arr3 is " + arr3.Max().ToString() + "  ,  " + arr3.Min().ToString());



            //5 - Write a program in C# Sharp to find the second largest element in an array.

            Array.Sort(arr3);
            Console.WriteLine("Second largest of arr3 is " + arr3[-2].ToString());






            //7 - Given a list of space separated words, reverse the order of the words.

            string sentence = "hello there i'am here";
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            string reservedSentence = string.Join(" ", words);

            //8- Write a program to create two multidimensional arrays of same size. Accept
            //value from user and store them in first array. Now copy all the elements of
            //first array on second array and print second array.

            int arrSize = int.Parse(Console.ReadLine());
            int[,] multiArr1 = new int[arrSize, arrSize];
            int[,] multiArr2 = new int[arrSize, arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.WriteLine("row 1");
                for (int j = 0; j < arrSize;)
                {
                    Console.WriteLine("Enter a vlaues for row 1");
                    bool result = int.TryParse(Console.ReadLine(), out multiArr1[i, j]);
                    if (result)
                        j++;
                    else
                        Console.WriteLine("Invalid input");
                }
            }

            Array.Copy(multiArr1, multiArr2, multiArr1.Length);


            //9 - Write a Program to Print One Dimensional Array in Reverse Order
            Array.Reverse(multiArr2);
            foreach (var item in multiArr2)
            {
                Console.WriteLine(item);
            }


        }

        public static void session()
        {
            int[] numbers;
            numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine($"legth of numbers is {numbers.Length}, rank of arr is {numbers.Rank}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"element {i} is {numbers[i]}");
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            int[] numbers01 = new int[3];
            int[] numbers02 = new int[3] { 1, 2, 3 };
            int[] numbers03 = new int[] { 1, 2, 3 };
            int[] numbers04 = { 1, 2, 3 };


            // 2d array

            Console.WriteLine("2d arr");

            int[,] marks = new int[2, 5];
            //{
            //    {1,2,3,4,5},
            //    {6,7,8,9,10}
            //};

            marks[0, 0] = 10;
            marks[0, 1] = 20;
            marks[0, 2] = 30;
            marks[0, 3] = 40;
            marks[0, 4] = 50;
            marks[1, 0] = 60;
            marks[1, 1] = 70;
            marks[1, 2] = 80;
            marks[1, 3] = 90;
            marks[1, 4] = 100;
            Console.WriteLine(marks[1, 4]);
            Console.WriteLine($"legth of numbers is {marks.Length}, rank of arr is {marks.Rank}");


            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine($"enter the grade of student {i + 1}");
                for (int j = 0; j < marks.GetLength(1);)
                {
                    Console.WriteLine($"enter the subjectnumber{j + 1}");

                    bool isParsed = int.TryParse(Console.ReadLine(), out marks[i, j]);
                    if (!isParsed)
                        Console.WriteLine("invalid input");
                    else
                        j++;
                }
            }


            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; i < marks.GetLength(1); j++)
                {
                    Console.WriteLine(marks[i, j]);
                }

            }


            ////////////////
            int[] arrMethods = { 1, 2, 3, 4, 5 };

            //arrMethods.Reverse();
            //Array.Clear(arrMethods);
            //Array.Clear(arrMethods,1,5);
            //Array.Resize(ref arrMethods, 20);




        }

    }
}
