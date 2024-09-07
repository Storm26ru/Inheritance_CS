using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = "Academy. Student, Jonson, 55 ";
			string[] bufer = line.Substring(line.IndexOf('.') + 1).Split(',');
			Console.WriteLine(bufer);
		}
	}
}
