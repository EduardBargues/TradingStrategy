using System.Collections.Generic;
using TradingStrategy.Investments;

namespace TradingStrategy.Portfolios
{
    public interface IPortfolio
    {
        IEnumerable<IInvestment> Investments { get; }
        double GetLiquidity();
        void Buy(string investmentId, double volume, double pricePerUnit);
        void Sell(string investmentId, double volume, double pricePerUnit);
    }
}
