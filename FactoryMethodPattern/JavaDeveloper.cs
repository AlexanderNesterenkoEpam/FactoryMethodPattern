using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
	public class JavaDeveloper : IDeveloper
	{
		public void writeCode()
		{
			Console.WriteLine("Write Java code...");
		}
	}
}
