using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryContracts;


namespace Repositories
{
	public class StocksRepository : IStocksRepository
	{
		private readonly ApplicationDbContext _db;
		/// <summary>
		/// Constructor of StocksRepository class that executes when a new object is created for the class
		/// </summary> 
		public StocksRepository(ApplicationDbContext stockMarkDbContext) { 
		_db = stockMarkDbContext;
		}
		public async Task<BuyOrder> CreateBuyOrder(BuyOrder buyOrder)
		{
			//add buy order object to buy orders list
			_db.BuyOrders.Add(buyOrder);
			await _db.SaveChangesAsync();

			return buyOrder;
		}

		public async Task<SellOrder> CreateSellOrder(SellOrder sellOrder)
		{
			//ass sell object to sell srders list
			_db.SellOrders.Add(sellOrder);
			await _db.SaveChangesAsync();
			return sellOrder;
		}

		public async Task<List<BuyOrder>> GetBuyOrders()
		{
			//get BuyOrder objects
			List<BuyOrder> buyOrders=await _db.BuyOrders.OrderByDescending(temp=>temp.DateAndTimeOfOrder).ToListAsync();

			return buyOrders;
		}

		public async Task<List<SellOrder>> GetSellOrders()
		{
			//get SellOrder object
			List<SellOrder> sellOrders = await _db.SellOrders.OrderByDescending(temp => temp.DateAndTimeOfOrder).ToListAsync();
			return sellOrders;
		}
	}
}
