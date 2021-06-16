using System;

namespace MethodExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = GetSmallestOfTheNumbers(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        private static int GetSmallestOfTheNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            
            if(firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                return firstNumber;
            }
            else if(secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }

    }
}
