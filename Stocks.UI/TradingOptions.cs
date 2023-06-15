﻿namespace StocksApp
{
    public class TradingOptions
    {
		/// <summary>
		/// Represents Options pattern for "StockPrice" configuration
		/// </summary>
		public uint? DefaultOrderQuantity { get; set; }
		public string? Top25PopularStocks { get; set; }
	}
}
