using System;

namespace FuncLamdaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Func Lamda Calculator  ");

            Func<int, int, int> addnumber =  (firstNum, secondNumber) => firstNum + secondNumber;

            Func<int, int, int> subractnumber = ( firstNum,  secondNumber) => firstNum - secondNumber;


            Func<int, int, int> multiplenumber = ( firstNum,  secondNumber) => firstNum * secondNumber;

            Func<int, int, int> divisionnumber = ( firstNum,  secondNumber) => firstNum / secondNumber;


            Calculator(addnumber, 16, 4);
            Calculator(subractnumber, 16, 4);            
            Calculator(multiplenumber, 16, 4);
            Calculator(divisionnumber, 16, 4);

            static void Calculator(Func<int, int, int> values, int firstNum, int secondNumber)
            {
                Console.WriteLine(values(firstNum, secondNumber));
            }

        }
    }
}
