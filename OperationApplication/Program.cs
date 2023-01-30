using System;
using System.Threading;
using System.Threading.Tasks;

namespace OperationApplication // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async void Main(string[] args) => Console.WriteLine(await Calculate(args));
        
        private static async Task<string> Calculate(string[] args)
        {
            Thread.Sleep(5000);
            if (args.Length != 3)
                return "Некорректное количество аргументов на вход!";
            
            string operation = args[(int)Arg.Operation].ToLower();
            double number1 = Convert.ToDouble(args[(int)Arg.Number1]);
            double number2 = Convert.ToDouble(args[(int)Arg.Number2]);

            char @operator = operation switch
            {
                "plus" => '+',
                "minus" => '-',
                "multiple" => '*',
                "divide" => '/',
                _ => '0'
            };

            if (@operator == '0')
                return "Неизместный оператор!";
            
            if (@operator == '/' && number2 == 0)
                return "Деление на нуль!";
            
            double result = @operator switch
            {
                '+' => number1 + number2,
                '-' => number1 - number2,
                '*' => number1 * number2,
                '/' => number1 / number2,
                _ => throw new NotImplementedException(),
            };

            return $"{number1} {@operator} {number2} = {result}";
        }

        enum Arg
        {
            Operation,
            Number1,
            Number2,
        }
    }
}