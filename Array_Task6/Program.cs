using System;
using System.Linq;

namespace Array_Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Task1
            //Console.WriteLine("Enter count of numbers");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //Console.WriteLine("Enter array elements");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int[] dubl = numbers.Distinct().ToArray();
            //if (dubl.Length != numbers.Length)
            //{
            //    Console.WriteLine("Duplicate ones: ");
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        for (int j = i + 1; j < numbers.Length; j++)
            //        {
            //            if (numbers[i] == numbers[j])
            //                Console.WriteLine(numbers[i]);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No dublicate elements");
            //}




            ////task2
            //Console.WriteLine("Enter count of numbers");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //Console.WriteLine("Enter array elements");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Which element do you want to find ?");
            //int find = int.Parse(Console.ReadLine());
            //bool t = Array.Exists(numbers, element => element == find);
            //Console.WriteLine(t);





            ////Task3
            //Console.WriteLine("Enter count of numbers");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //Console.WriteLine("Enter array elements");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Array.ForEach(numbers, num => Console.WriteLine(num));




            ////Task4
            //Console.WriteLine("Enter count of numbers");
            //int n = int.Parse(Console.ReadLine());
            //string[] names = new string[n];
            //Console.WriteLine("Enter array elements");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Enter char ");
            //string s = Console.ReadLine();
            //Array.ForEach(Array.FindAll(names, x => x.StartsWith(s)), Console.WriteLine);




            ////Task5
            //Console.WriteLine("Enter count of numbers");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //Console.WriteLine("Enter array elements");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter count of numbers");
            //int m = int.Parse(Console.ReadLine());
            //int[] numbers2 = new int[m];
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    numbers2[i] = int.Parse(Console.ReadLine());
            //}

            //int array1OriginalLength = numbers.Length;
            //Array.Resize<int>(ref numbers, array1OriginalLength + numbers2.Length);
            //Array.Copy(numbers2, 0, numbers, array1OriginalLength, numbers2.Length);

            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);



            //Task 6
            Console.WriteLine("Enter count of numbers");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter count of numbers");
            int m = int.Parse(Console.ReadLine());
            int[] numbers2 = new int[m];
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = int.Parse(Console.ReadLine());
            }
            int[] same = numbers.Intersect(numbers2).ToArray(); ;
            int[] different = numbers.Union(numbers2).Except(same).ToArray();
            
            Console.WriteLine("Same ones");
            for (int i = 0; i < same.Length; i++)
            {
                Console.WriteLine(same[i]);
            }
            Console.WriteLine("Different ones");
            for (int i = 0; i < different.Length; i++)
            {
                Console.WriteLine(different[i]);
            }
        }
    }
}
