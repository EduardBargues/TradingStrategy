using System.Collections.Generic;
using System.Linq;
using TradingStrategy.Investments;

namespace TradingStrategy.Portfolios
{
    public class Portfolio : IPortfolio
    {
        private readonly Dictionary<string, IInvestment> investmentsById;
        private double liquidity;

        public IEnumerable<IInvestment> Investments => investmentsById.Values;

        protected Portfolio(IEnumerable<IInvestment> investments)
        {
            investmentsById = investments
                .ToDictionary(investment => investment.Id);
        }

        public double GetLiquidity()
        {
            return liquidity;
        }
        public void Buy(string id, double volume, double pricePerUnit)
        {
            IInvestment investment = investmentsById[id];
            liquidity -= volume * pricePerUnit;
            investment.Quantity += volume;
        }
        public void Sell(string id, double volume, double pricePerUnit)
        {
            IInvestment investment = investmentsById[id];
            liquidity += volume * pricePerUnit;
            investment.Quantity -= volume;
        }
    }
}
