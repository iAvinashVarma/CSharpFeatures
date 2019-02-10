using CSharp5.Logger;
using System;
using System.Threading;

namespace CSharp5.ThreadWay
{
	public class StockService
	{
		LoggerBase logger = new DebugLogger();

		public void FetchStocks()
		{
			var threadOne = new Thread(() =>
			{
				HiEveryFiveSeconds();
			});
			threadOne.Start();
		}

		private void HiEveryFiveSeconds()
		{
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(5000);
				Action action = () => logger.Log("Hi Avi {0}", i);
				action.BeginInvoke(null, null);
			}
		}
	}
}
