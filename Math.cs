using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
	interface IMath
	{
		void Addition(double n1, double n2); //сложение
		void Subtraction(double n1, double n2); //вычитание
		void Multiplication(double n1, double n2); //умножение
		void Division(double n1, double n2); //деление
	}
	delegate void Operation(double n1, double n2);
	class Calculator : IMath
	{
		public void Addition(double n1, double n2) => Console.WriteLine($"Cложение: {n1 + n2}");
		public void Subtraction(double n1, double n2) => Console.WriteLine($"Вычитание: {n1 - n2}");
		public void Multiplication(double n1, double n2) => Console.WriteLine($"Умножение: {n1 * n2}");
		public void Division(double n1, double n2)
		{
			if (n2 != 0) Console.WriteLine($"Деление: {(n1 / n2)}");
			else Console.WriteLine("Не дели на 0, дурашка");
		} 
	}
}
