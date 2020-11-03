using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press 1 to start program, 0 to end program \n");
            int start = int.Parse(Console.ReadLine());
            while (start == 1)
            {
                Console.Write("Enter a value to select a program. \n");
                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        multiply3();
                        break;
                    case 2:
                        display4times();
                        break;
                    case 3:
                        TemperatureConvert();
                        break;
                    case 4:
                        inRange();
                        break;
                    case 5:
                        multiplyArray();
                        break;
                }
                Console.Write("Would you like to select another program? 1 = yes 0 = no \n");
                start = int.Parse(Console.ReadLine());
            }

            static void multiply3()
            {
                int number1, number2, number3, answer;
                Console.Write("\nInput the First Number : ");
                number1 = int.Parse(Console.ReadLine());
                Console.Write("\nInput the Second Number : ");
                number2 = int.Parse(Console.ReadLine());
                Console.Write("\nInput the First Number : ");
                number3 = int.Parse(Console.ReadLine());
                answer = number1 * number2 * number3;
                Console.Write("\n {0} x {1} x {2} = {3} \n", number1, number2, number3, answer);
            }

            static void display4times()
            {
                Console.Write("Input number to display 4 times \n");
                int number = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 4; i++)
                {
                    Console.Write("\n{0} has been output {1} time(s)", number, i);
                }
                Console.Write("\n");
            }

            static void TemperatureConvert()
            {
                //kelvin = celsius + 273
                //fahrenheit = celsius x 18 / 10 + 32
                Console.Write("Enter Celsius Amount to convert: ");
                int celsius = int.Parse(Console.ReadLine());
                int kelvin = celsius + 273;
                int fahrenheit = ((celsius * 18) / 10) + 32;
                Console.Write("Temperature in Kelvin: {0} \n", kelvin);
                Console.Write("Temperature in Fahrenheit: {0} \n", fahrenheit);
            }

            static void inRange()
            {
                Console.Write("Write a C# program to check if a given integer is within 20 of 100 or 200 \n");
                int number = int.Parse(Console.ReadLine());
                Boolean result = false;
                if (((number > 80) && (number < 120)) || ((number > 180) && (number < 220)))
                {
                    result = true;
                }

                Console.Write(result + "\n");
            }

            static void multiplyArray()
            {
                Console.Write("Write a C# program to multiply corresponding elements of two arrays of integers.\n");
                Console.Write("Enter 5 digits for Array 1 \n");
                int[] array1 = new int[5];
                int[] array2 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    int temp = int.Parse(Console.ReadLine());
                    array1[i] = temp;
                }

                Console.Write("Enter 5 digits for Array 2 \n");
                for (int j = 0; j < 5; j++)
                {
                    int temp1 = int.Parse(Console.ReadLine());
                    array2[j] = temp1;
                }

                for (int k = 0; k < array1.Length; k++)
                {
                    Console.Write(array1[k] * array2[k] + " ");
                }
                Console.Write("\n");

            }
        }
    }
}
