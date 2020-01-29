using System;

namespace BVA_TestingExample
{
    class Program
    {
        private const string Value = "Enter the number of test scenarios you would like to run as part of this BVA exercise";

        static void Main(string[] args)
        {
            Console.WriteLine(Value);
            int vary = Convert.ToInt32(Console.ReadLine());
            startBVA(vary);  
        }

        public static void startBVA(int vary)
        {
            
            Console.WriteLine("Enter A Boundary To Test");
            int inputBoundary = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[vary];

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Enter a Value:");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out arr[i]))
                    {
                        Console.Write("Array = " + string.Join(", ", arr[i]) + "\r\n");
                    }
                    if (arr[i] <= inputBoundary && arr[i] > 0)
                        Console.WriteLine("pass\r\n");

                    else if (arr[i] < 0)
                        Console.WriteLine("fail\r\n");

                    else
                        Console.WriteLine("fail\r\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
