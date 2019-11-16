/*
	Just we're clear. I am rather anal about openning an closing brackets.
	They will be on separate line. That is my Pet Peeve.
*/

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
		//private List<_Item> _Inventory = new List<_Item>();

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
			int _found = 0;

			// 30% chance of getting lucky
			if(rnd < 3)
			{
				_Luck++;
				// Add some credits, compounded bonus.
				for(int a=0 ; a < _Luck ; a++)
				{
					_found = _Rand.Next(3) + _Bonus;
				}
				Console.WriteLine("HEY! You found " + _found + " Credits.");
				_Credits += _found;
				Console.WriteLine("Credits: " + _Credits);
			}
		}
	}

    static class Program
    {
        static void Main()
        {
			int _Turns = 1;
			char _Choice;

			_Character Char = new _Character();

			_Game._SetupGame(Char);

			// Main Loop Start
			while(!_Game._Over)
			{
				Console.WriteLine("\n");
				Console.WriteLine("Turn Number: " + _Turns);
				Console.WriteLine("What you like to do?");
				Console.WriteLine("s) Search w) Wait , q) Quit");
				_Choice = char.ToLower(Console.ReadKey().KeyChar);

				switch(_Choice)
				{
					case 'q':
						Console.WriteLine("uiting");
						_Game._Over = true;
						break;
					case 's':
						Console.WriteLine("earching. +1 Luck");
						Char.Lucky(1);
						break;
					case 'w':
						Console.WriteLine("aiting");
						Char.Lucky(0);
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
