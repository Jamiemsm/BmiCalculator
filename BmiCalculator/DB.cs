using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculator
{
	class DB
	{
		string hej = "hej salim";

		static void Reader()
		{
			StreamReader sr = new StreamReader("DB.txt");

			string[] alleLinjer = File.ReadAllLines("DB.txt");
		}

		static void Writer(int height, int weight)
		{
			StreamWriter sw = new StreamWriter("DB.txt");
			sw.WriteLine("height: " + height);
			sw.WriteLine("weight: " + weight);
			sw.Flush();
			sw.Close();
		}
	}
}
