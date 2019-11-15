using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
	class _Character
	{
		private string _CharName;
		private int _Luck = 0;
		private int _Credits = 0;
		private List<_Item> _Inventory = new List<_Item>();

		public void SetName()
		{
			Console.WriteLine("What is your name?");
			_CharName = Console.ReadLine();
		}

		public string GetName()
		{
			return _CharName;
		}

		public int GetLuck()
		{
			return _Luck;
		}

		public int GetCredits()
		{
			return _Credits;
		}

		public void Lucky(int _Bonus)
		{
			Random _Rand = new Random();
			int rnd = _Rand.Next(10);

			if(rnd > 8)
			{
				_Luck++;
				Console.WriteLine("You got lucky.");
				for(int a=0 ; a < (_Luck + _Bonus) ; a++)
				{
					_Credits += _Rand.Next(10);
				}
				Console.WriteLine("Credits: " + GetCredits());
			}
		}
	}

    static class Program
    {
        static void Main()
        {
			int _Turns = 0;
			char _Choice;

			_Character Char = new _Character();

			_Game._SetupGame(Char);

			// Main Loop Start
			while(!_Game._Over)
			{
				Console.WriteLine("Turn Number: " + _Turns);
				Console.WriteLine("What you like to do?");
				Console.WriteLine("w) Wait , q) Quit");
				_Choice = Console.ReadKey().KeyChar;
				Console.WriteLine("\n");

				switch(_Choice)
				{
					case 'q':
						_Game._Over = true;
						break;
					case 'w':
					default:
						Console.WriteLine("Waiting");
						Char.Lucky(1);
						break;
				}
				_Turns++;
			}
			// Main Loop End

			Console.WriteLine("Looks like the game is over.");
        }       
    }

	static class _Game
	{
		public static bool _Over = false;
		private static string _GameName = "SumDum World";

		public static string _GetGameName()
		{
			return _GameName;
		}

		public static void _SetupGame(_Character Char)
		{
			Char.SetName();

			Console.WriteLine("Welcome "+ Char.GetName() +" to "+ _Game._GetGameName() +". You will be exploring the fantastic world of SumDum. ");
		}


	}

	class _Item
	{
		// Constructor
		public _Item()
		{

		}
	}
}
