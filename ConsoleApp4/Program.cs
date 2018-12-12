using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{		// FÜR UNGRADE ZAHLEN FUNKTIONIERT ES SCHON MAL...
		static void Main(string[] args)
		{
		int zahl;
		Console.Write("Bitte gib eine ungrade Zahl ein: ");
		zahl = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();

				//Zeilensteuerung
			for (int j = 1; j <= zahl/2+1; j++)
			{
				//Spaltensteuerung + X Setzer
				for (int i = j; i <= zahl+1 -j; i++)
				{
					Console.Write("X" +" ");
					
				}
				
				//Pre-Leerzeichen-Setzer (Für Anzahl Fehlender X-e am Anfang der Zeile)
				if ((j < zahl/2+1) == true)
				Console.WriteLine();
				for (int h = 0; h < j; h++)
				{
					Console.Write("  ");
				}
			
			}
			/*
			 *DER FOLGENDE CODE IST MEINER PERSÖNLICHEN LOGIK ENTSPRUNGEN;-)
			 * zu beachten ist: die inneren for schleifen sind vertauscht,
			 * weil (in meiner Lösungsvariante) die Leerspalten zuerst gesetzt werden sollen...
			 * Die Anzahl der Zeilen sind (Zahl-1)/2 [also bei z.B. 5 (5-1)/2 =2....und j--]
			 * Die Anzahl der ("  ") Doppelleerzeichen soll pro Zeile um zwei Abnehmen, also 
			 * die Anzahl um die, die ("Y" + " ") zunehmen... (siehe innere For-Schleifen).
			 */
			Console.WriteLine("    :-)");	
			for (int j = (zahl-1)/2; j >= 1 ; j--) //diesmal -1 damit die Sanduhr keinen lange
			{
				
				for (int h = j-1; h >= 1; h-- )  //hier anders als: (vgl. ~26. Zeile)... um die Anzahl der Leerspalten abzubauen.
				{
					Console.Write("  ");
				}
				//
				for (int i = 0; i <= zahl-(j*2-1); i++ ) //Parameter erfolgreich getuned... 
				{
					Console.Write("Y" + " ");
				}
				Console.WriteLine();
		
			}
		}
	}
}
