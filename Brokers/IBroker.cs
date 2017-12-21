using TradingStrategy.Actions;
using TradingStrategy.Actors;
using TradingStrategy.Portfolios;

namespace TradingStrategy.Brokers
{
    public interface IBroker
    {
        double GetFee(ITransaction action);
        IPortfolio GetClientPortfolio(string clientId);
        IActor GetClient(string clientId);
    }
}
