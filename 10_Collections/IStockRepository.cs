using System.Collections;

namespace _10_Collections {
	internal interface IStockRepository {
		long NextId();
		void SaveStock(Stock Stock);
		Stock LoadStock(long id);
		ICollection FindAllStocks();
		void Clear();
	}
}