using System;

namespace ActionLamdaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Action Lamda Calculator");

            Action<int, int> addNumber = (firstNumber, secondNumber) =>
            Console.WriteLine($"Adding Number is : {firstNumber + secondNumber}");

            Action<int, int> subractNumber = (firstNumber, secondNumber) =>
              Console.WriteLine($"Subracting Number is : {firstNumber - secondNumber}");

            Action<int, int> multipleNumber = (firstNumber, secondNumber) =>
            Console.WriteLine($"Adding Number is : {firstNumber * secondNumber}");

            Action<int, int> divisiontNumber = (firstNumber, secondNumber) =>
            Console.WriteLine($"Subracting Number is : {firstNumber / secondNumber}");

            Calculator(addNumber += subractNumber += multipleNumber += divisiontNumber, 12, 4);

            Console.ReadKey();



            static void Calculator(Action<int, int> values, int firstNumber, int secondNumber)
            {
                values(firstNumber, secondNumber);
            }

        }
    }
}
