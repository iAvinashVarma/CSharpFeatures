using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5.Logger
{
	public abstract class LoggerBase : ILogger
	{
		public virtual string Line(string format, params object[] values)
		{
			var text = string.Format(format, values);
			var line = string.Format("{0:HH:mm:ss.fff}: {1}\r\n", DateTime.Now, text);
			return line;
		}

		public abstract void Log(string format, params object[] values);
	}
}
