using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
		int zahl,zahlC;

		Console.WriteLine("Zahl:");
		zahl = Convert.ToInt32(Console.ReadLine());
		zahlC = zahl;
			for (int j = 1; j <= zahl/2+1; j++)
			{
				//Spaltensteuerung
				for (int i = j; i <= zahl+1 -j; i++)
				{
					Console.Write("X" +" ");
				}
				Console.WriteLine();
				for (int h = 0; h < j; h++)
				{
				Console.Write("  ");
				}
			
			}
			//Spiegelung
			//for (int k = 1; k <= zahlC*2-1; k--)
			//{
			//	//Spaltensteuerung
			//	for (int m = 0; m < 5; m--)
			//	{
			//	Console.Write("  ");
			//	}	
			//	for (int l = k; l <= zahlC -1 -k; l--)
			//	{
			//		Console.Write(l +" ");
			//}
			//	Console.WriteLine();
						
			//}
		}
	}
}
