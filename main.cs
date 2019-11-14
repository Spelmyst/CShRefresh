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

		public void _SetName()
		{
			Console.WriteLine("What is your name?");
			_CharName = Console.ReadLine();
		}

		public string _GetName()
		{
			return _CharName;
		}
	}

    static class Program
    {
        static void Main()
        {
			_Character _Char = new _Character();

			_Game._SetupGame(_Char);

			Console.WriteLine("Welcome "+ _Char._GetName() +" to "+ _Game._GetGameName() +". You will be exploring the fantastic world of SumDum. ");
			//Console.ReadKey();
        }       
    }

	static class _Game
	{
		private static string _GameName = "SumDum World";

		public static string _GetGameName()
		{
			return _GameName;
		}

		public static void _SetupGame(_Character _Char)
		{
			_Char._SetName();
		}
	}

	class _Item
	{

	}
}
