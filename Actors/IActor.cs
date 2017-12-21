using System.Collections.Generic;
using TradingStrategy.Brokers;

namespace TradingStrategy.Actors
{
    public interface IActor
    {
        string Name { get; }
        IEnumerable<IBroker> Brokers { get; }
    }
}
