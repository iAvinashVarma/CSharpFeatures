using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5.Logger
{
	public class DebugLogger : LoggerBase
	{
		public override void Log(string format, params object[] values)
		{
			Debug.WriteLine(Line(format, values));
		}
	}
}
