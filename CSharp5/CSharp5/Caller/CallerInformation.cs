using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CSharp5.Caller
{
	public class CallerInformation
	{
		public void TraceMessage(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
		{
			Trace.WriteLine("Message: " + message);
			Trace.WriteLine("Member name: " + memberName);
			Trace.WriteLine("Source file path: " + sourceFilePath);
			Trace.WriteLine("Source line number: " + sourceLineNumber);
		}
	}
}
