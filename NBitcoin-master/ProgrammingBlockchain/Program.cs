using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingBlockchain.Chapters;

namespace ProgrammingBlockchain
{
	class Program
	{
		static void Main(string[] args)
		{
			var chapter1 = new Chapter1();
			chapter1.Lesson1();
			Console.WriteLine("\n Press Enter to Continue");
			Console.ReadLine();
		}
	}
}
