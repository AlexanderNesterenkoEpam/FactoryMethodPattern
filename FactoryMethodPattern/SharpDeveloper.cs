using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
	public class SharpDeveloper : IDeveloper
	{
		public void writeCode()
		{
			Console.WriteLine("Write C# code ...");
		}

	}
}
