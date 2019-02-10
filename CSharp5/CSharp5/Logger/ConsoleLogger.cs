using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5.Logger
{
	public class ConsoleLogger : LoggerBase
	{
		public override void Log(string format, params object[] values)
		{
			Console.WriteLine(Line(format, values));
		}
	}
}
