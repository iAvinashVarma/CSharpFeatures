using System.Collections.Generic;

namespace CSharp4.Parameter
{
	public class Parameters
	{
		public int Key { get; set; }

		public int Value { get; set; }

		public Parameters(int key = 3, int value = 4)
		{
			Key = key;
			Value = value;
		}

		public KeyValuePair<int, int> Output()
		{
			return new KeyValuePair<int, int>(key: Key, value: Value);
		}

		public KeyValuePair<int, string> OptionalMethod(int key = 1, string value = "Optional")
		{
			return new KeyValuePair<int, string>(key, value);
		}

		public KeyValuePair<int, string> NamedMethod(int key = 2, string value = "Named")
		{
			return new KeyValuePair<int, string>(key: key, value: value);
		}

		public KeyValuePair<int, string> OverloadResolution(int key)
		{
			return new KeyValuePair<int, string>(key: key, value: string.Format("{0}", "Numeric"));
		}

		public KeyValuePair<int, string> OverloadResolution(int key, string value = "Optional")
		{
			return new KeyValuePair<int, string>(key: key, value: string.Format("{0}", value));
		}

		public KeyValuePair<double, string> OverloadResolution(double key)
		{
			return new KeyValuePair<double, string>(key: key, value: string.Format("{0}", "Floating"));
		}

		public KeyValuePair<T, string> OverloadResolution<T>(T genKey)
		{
			return new KeyValuePair<T, string>(key: genKey, value: string.Format("{0}", "Generic"));
		}
	}
}