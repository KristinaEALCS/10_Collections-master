using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _10_Collections {
	internal class Portfolio : IAsset {
		private List<IAsset> Assets;

		public Portfolio(List<IAsset> stocks) {
			this.Assets = stocks;
		}

		public Portfolio() {
			Assets = new List<IAsset>();
		}

		public double GetTotalValue() {
			double Sum = 0;

			foreach (IAsset stock in Assets) {
				Sum += stock.GetValue();
			}

			return Sum;
		}

		public void AddAsset(IAsset Stock) {
			this.Assets.Add(Stock);
		}

		public string GetName() {
			throw new NotImplementedException();
		}

		public double GetValue() {
			throw new NotImplementedException();
		}

		internal IList<IAsset> GetAssets() {
			return this.Assets.AsReadOnly();
		}

		internal IAsset GetAssetByName(string Sym) {
			IAsset ReturnAsset = null;
			foreach(IAsset Asset in Assets) {
				if (Asset.GetName() == Sym) {
					ReturnAsset = Asset; break;
				}
			}

			return ReturnAsset;
		}

		internal IList<IAsset> GetAssetsSortedByName() {
			Assets.Sort(new StockNameComparator());
			return Assets;
		}

		internal IList<IAsset> GetAssetsSortedByValue() {
			Assets.Sort(new StockValueComparator());
			return Assets;
		}
	}
}