using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadixCalculator
{
	public partial class MixedRadixSystem
	{
		/// <summary>
		/// Provides access to pre-defined RadixCalculator class instances
		/// </summary>
		public static class Factory
		{
			public static MixedRadixSystem TimeDateRadix1()
			{
				List<long> SortableDate = new List<long>();

				SortableDate.Add(60); // Seconds in minute
				SortableDate.Add(60); // Minutes in hour
				SortableDate.Add(24); // Hours in day
				SortableDate.Add(7);  // Days a week
				SortableDate.Add(52); // Weeks a year

				return new MixedRadixSystem(SortableDate);
			}

			public static MixedRadixSystem Base2()
			{
				return new MixedRadixSystem(2, 8);
			}

			public static MixedRadixSystem Base10()
			{
				return new MixedRadixSystem(10, 7);
			}

			public static MixedRadixSystem Base12()
			{
				return new MixedRadixSystem(12, 8);
			}

			public static MixedRadixSystem Base16()
			{
				return new MixedRadixSystem(16, 8);
			}
		}
	}
}
