using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
	public class SharpDeveloperFactory : IDeveloperFactory
	{
		public IDeveloper CreateDeveloper()
		{
			return new SharpDeveloper();
		}
	}
}
