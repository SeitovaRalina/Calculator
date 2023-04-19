//Напишите программу на C#, которая будет иметь список делегатов для математических операций (сложение, вычитание, умножение и деление).
//Пользователь должен иметь возможность выбрать операцию и ввести два числа.
//После этого программа должна вызвать соответствующий делегат и вывести результат на экран.
//Создайте интерфейс IMath, который будет содержать методы для всех четырех математических операций

namespace calculator
{
    internal class Menu
    {
        static int Move(int i, int n, ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                i = (n + i - 1) % n;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                i = (n - (n - i - 1)) % n;
            }
            return i;
        }
        static void Main(string[] args)
        {
            Operation op;
            IMath calc = new Calculator();
            double n1, n2;

            int i = 0;
            while (true)
            {
                Console.SetCursorPosition(0,0);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition((Console.WindowWidth / 2) - ( 38 / 2),0);
                Console.WriteLine("Л/Р № 3: Бинарные операции над числами");
                Console.SetCursorPosition(0, 2);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("- \tC л О ж Е н И е");
                Console.WriteLine("- \tВ ы Ч и т А н И е");
                Console.WriteLine("- \tУ м н О Ж е Н и Е");
                Console.WriteLine("- \tД е л Е Н и Е");
                Console.SetCursorPosition(4, i + 2);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.Write("Введите первое число: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    n2 = double.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 0:
                            op = calc.Addition;
                            op(n1,n2);
                            break;
                        case 1:
                            op = calc.Subtraction;
                            op(n1, n2);
                            break; 
                        case 2:
                            op = calc.Multiplication;
                            op(n1, n2);
                            break;
                        case 3: 
                            op = calc.Division;
                            op(n1, n2);
                            break;
                    }
                    Console.WriteLine();
                    Console.Write("Нажмите любую клавишу, чтобы выйти : ");
                    Console.ReadKey();
                    Console.Clear();
                }
                i = Move(i, 4, key);
            }
        }
    }
}

