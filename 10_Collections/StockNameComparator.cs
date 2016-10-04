using System;
using System.Collections.Generic;

namespace _10_Collections {
	internal class StockNameComparator : IComparer<IAsset> {
		public StockNameComparator() {
		}

		public int Compare(IAsset A1, IAsset A2) {
			return string.Compare(A1.GetName(), A2.GetName());
		}
	}
}