namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Введите действие (+, -, *, /, ^, √): ");
                string op = Console.ReadLine();

                double result = 0;

                if (op == "√")
                {
                    // извлечение корня
                    result = Math.Sqrt(num1);
                    Console.WriteLine($"Результат: √{num1} = {result}");
                    return;
                }

                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                            Console.WriteLine("Ошибка: деление на ноль!");
                        else
                            result = num1 / num2;
                        break;
                    case "^":
                        result = Math.Pow(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Неизвестное действие!");
                        break;
                }
                Console.WriteLine($"Результат: {result}");
            }
        }
    }

