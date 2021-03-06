﻿using System;
using System.Collections.Generic;
using TradingStrategy.Actions;
using TradingStrategy.Actors;
using TradingStrategy.Portfolios;

namespace TradingStrategy.Brokers
{
    public class Broker : IBroker
    {
        private Dictionary<string, IActor> clientsById;
        private Dictionary<string, IPortfolio> portfolioByClientId;
        private readonly Func<ITransaction, double> feeFunction;

        public string Name { get; set; }

        public Broker(Func<ITransaction, double> feeFunction)
        {
            this.feeFunction = feeFunction;
        }

        public double GetFee(ITransaction action)
        {
            return feeFunction(action);
        }
        public IPortfolio GetClientPortfolio(string clientId)
        {
            return portfolioByClientId[clientId];
        }
        public IActor GetClient(string clientId)
        {
            return clientsById[clientId];
        }
    }
}