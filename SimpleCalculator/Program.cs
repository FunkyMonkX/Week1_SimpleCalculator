using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
	class Program
	{
		static void Main(string[] args)
		{

			string title = @"
  _________.__               .__         _________        .__               .__          __                
 /   _____/|__| _____ ______ |  |   ____ \_   ___ \_____  |  |   ____  __ __|  | _____ _/  |_  ___________ 
 \_____  \ |  |/     \\____ \|  | _/ __ \/    \  \/\__  \ |  | _/ ___\|  |  \  | \__  \\   __\/  _ \_  __ \
 /        \|  |  Y Y  \  |_> >  |_\  ___/\     \____/ __ \|  |_\  \___|  |  /  |__/ __ \|  | (  <_> )  | \/
/_______  /|__|__|_|  /   __/|____/\___  >\______  (____  /____/\___  >____/|____(____  /__|  \____/|__|   
        \/          \/|__|             \/        \/     \/          \/                \/                   

";

			Console.WriteLine(title);
			Console.WriteLine("Welcome to simple calculator!");

			double firstNumber = 0;
			double secondNumber = 0;
			double operationResult = 0;
			string operatorSymbol = "";
			bool inputValid = false;
			string moreCalculations = "";

			do
			{
				do
				{
					Console.Write("Provide first number: ");
					string firstInput = Console.ReadLine();
					if (Double.TryParse(firstInput, out firstNumber))
					{
						inputValid = true;
					}
					else
					{
						inputValid = false;
						Console.WriteLine($"{firstInput} is not a valid number!");
					}
				} while (inputValid == false);

				do
				{
					Console.Write("Provide second number: ");
					string secondInput = Console.ReadLine();
					if (Double.TryParse(secondInput, out secondNumber))
					{
						inputValid = true;
					}
					else
					{
						inputValid = false;
						Console.WriteLine($"{secondInput} is not a valid number!");
					}
				} while (inputValid == false);

				do
				{
					if (secondNumber == 0)
					{
						Console.Write("Provide one of the legal operators (+ OR - OR *): ");
					}
					else
					{
						Console.Write("Provide one of the legal operators (+ OR - OR / OR *): ");
					}
					string operatorInput = Console.ReadLine();
					operatorSymbol = operatorInput;
					if (operatorInput != "+" && operatorInput != "-" && operatorInput != "/" && operatorInput != "*")
					{
						inputValid = false;
						Console.WriteLine($"{operatorInput} is not a valid operator!");
					}
					else
					{
						inputValid = true;
						if (secondNumber == 0 && operatorInput == "/")
						{
							Console.WriteLine("Division by 0 is not allowed! Please provide different operator.");
							inputValid = false;
						}
					}
				} while (inputValid == false);

				operationResult = Calculator.CalculateResult(firstNumber, secondNumber, operatorSymbol);
				Console.WriteLine($"The result of {firstNumber} {operatorSymbol} {secondNumber} is {operationResult}");
				Console.WriteLine("More calculations? (y/n): ");
				moreCalculations = Console.ReadLine();
			} while (moreCalculations == "y");

			Console.WriteLine("Bye!");
		}
	}
}