using System;
using CandleTimeSeriesAnalysis;
using TradingStrategy.Actions;

namespace TradingStrategy.Strategies
{
    public interface IStrategy
    {
        ITransaction GetTradeInfo(CandleTimeSeries series, DateTime date);
    }
}
