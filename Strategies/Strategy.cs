using System;
using CandleTimeSeriesAnalysis;
using TradingStrategy.Actions;

namespace TradingStrategy.Strategies
{
    public abstract class Strategy : IStrategy
    {
        private readonly Func<CandleTimeSeries, DateTime, ITransaction> f;
        protected Strategy(Func<CandleTimeSeries, DateTime, ITransaction> f)
        {
            this.f = f;
        }

        public ITransaction GetTradeInfo(CandleTimeSeries series, DateTime date)
        {
            return f(series, date);
        }
    }
}
