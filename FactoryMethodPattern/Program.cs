using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IDeveloperFactory factory = CreateDevBySpeciality("Java");
			IDeveloper dev = factory.CreateDeveloper();

			dev.writeCode();
		}

		public static IDeveloperFactory CreateDevBySpeciality(String speciality)
		{
			if (speciality.Equals("Java"))
			{
				return new JavaDeveloperFactory();
			}
			else if (speciality.Equals("Sharp"))
			{
				return new SharpDeveloperFactory();
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}
}
