using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
	public static class Calculator
	{
		public static double CalculateResult(double firstNum, double secondNum, string operation)
		{
			double CalculationResult = 0;
			switch (operation)
			{
				case "*":
					CalculationResult = firstNum * secondNum;
					break;
				case "/":
					CalculationResult = firstNum / secondNum;
					break;
				case "+":
					CalculationResult = firstNum + secondNum;
					break;
				case "-":
					CalculationResult = firstNum - secondNum;
					break;
			}

			return CalculationResult;
		}

	}
}
