/*
 *
 * Developed by Adam Rakaska
 *  http://csharpcodewhisperer.blogspot.com
 *    http://arakaska.wix.com/intelligentsoftware
 *
 *
 * Made using SharpDevelop
 *
 * 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;


namespace RadixCalculator
{
	public class RadixCalculator
	{
		public bool RightToLeft { get; set; }
		List<int> _baseArray { get; set; }
		List<int> _valueArray { get; set; }
		//List<string> _nameArray { get; set; }
		//List<char> _symbolArray { get; set; }
		int index;

		#region Constructors

		public RadixCalculator(List<int> Definitions)
		{
			_baseArray = Definitions;
			_valueArray = new List<int>();

			int counter = Definitions.Count;
			while (counter-- > 0)
			{
				_valueArray.Add(0);
			}

			Init();
		}

		public RadixCalculator(int Base, int Precision)
			: this(Enumerable.Repeat<int>(Base, Precision).ToList())
		{ }

		#endregion

		public void Init()
		{
			RightToLeft = true;
		}

		public void Increment()
		{
			if (_valueArray[index] >= _baseArray[index] - 1)
			{
				_valueArray[index++] = 0;
				Increment();
			}
			else
			{
				_valueArray[index]++;
				index = 0;
			}
		}

		public void Increment(int Value)
		{
			while (Value-- > 0)
			{
				Increment();
			}
		}

		public List<int> GetValueArray()
		{
			return _valueArray;
		}

		public string GetValue()
		{
			return formatArrayString(_valueArray);
		}

		public override string ToString()
		{
			return formatArrayString(_baseArray);
		}

		private string formatArrayString(List<int> array)
		{
			StringBuilder result = new StringBuilder();

			foreach (int i in array)
			{
				if (RightToLeft)
				{
					result.Insert(0, string.Format("{0}:", i));
				}
				else
				{
					result.AppendFormat("{0}:", i);
				}
			}

			// Remove trailing colon, ":"
			result = result.Remove(result.Length - 1, 1);

			return result.ToString();
		}


		#region RadixCalculator static Factory

		/// <summary>
		/// Provides access to pre-defined RadixCalculator class instances
		/// </summary>
		public static class Factory
		{
			public static RadixCalculator TimeDateRadix1()
			{
				List<int> SortableDate = new List<int>();

				SortableDate.Add(60); // Seconds in minute
				SortableDate.Add(60); // Minutes in hour
				SortableDate.Add(24); // Hours in day
				SortableDate.Add(7);  // Days a week
				SortableDate.Add(52); // Weeks a year

				return new RadixCalculator(SortableDate);
			}

			public static RadixCalculator Base2()
			{
				return new RadixCalculator(2, 8);
			}

			public static RadixCalculator Base10()
			{
				return new RadixCalculator(10, 7);
			}

			public static RadixCalculator Base12()
			{
				return new RadixCalculator(12, 8);
			}

			public static RadixCalculator Base16()
			{
				return new RadixCalculator(16, 8);
			}
		}

		#endregion

	}
}
