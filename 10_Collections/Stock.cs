namespace _10_Collections {
	internal class Stock : IAsset {
		private string symbol;
		private double pricePerShare;
		private int numShares;

		public string Symbol { get { return this.symbol; } set { this.symbol = value; } }
		public double PricePerShare { get { return this.pricePerShare; } set { this.pricePerShare = value; } }
		public int NumShares { get { return this.numShares; } set { this.numShares = value; } }

		public int Id { get; internal set; } = 0;

		public Stock(string Sym, double Pps, int Ns) {
			this.symbol = Sym;
			this.pricePerShare = Pps;
			this.numShares = Ns;
		}

		public Stock() { }

		public double GetValue() {
			return this.numShares * this.pricePerShare;
		}

		internal static double TotalValue(IAsset[] stocks) {
			double sum = 0;

			foreach (IAsset stock in stocks) {
				sum += stock.GetValue();
			}

			return sum;
		}

		public string GetName() {
			return this.Symbol;
		}

		public override string ToString() {
			return "Stock["
				+ "symbol=" + this.symbol
				+ ",pricePerShare=" + this.pricePerShare
				+ ",numShares=" + this.numShares
				+ "]";
		}

		public override bool Equals(object obj) {
			Stock s = (Stock)obj;

			return (
				(this.Symbol == s.Symbol) &&
				(this.PricePerShare == s.PricePerShare) &&
				(this.NumShares == s.NumShares)
			);
		}
	}
}