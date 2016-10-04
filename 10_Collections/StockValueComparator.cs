using System;
using System.Collections.Generic;

namespace _10_Collections {
	internal class StockValueComparator : IComparer<IAsset> {
		public int Compare(IAsset A1, IAsset A2) {
			return A2.GetValue().CompareTo(A1.GetValue());
		}
	}
}