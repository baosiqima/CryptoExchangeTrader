﻿using System;
using CryptoExchangeTrader.Handlers;
using CryptoExchangeTrader.Models;

namespace CryptoExchangeTrader.Exchanges
{
    public class Bitfinex : Exchange
    {
        /// <summary>
        /// Initialise a Bitfinex Exchange
        /// </summary>
        /// <param name="exchangeConfiguration"></param>
        protected Bitfinex(ExchangeConfiguration exchangeConfiguration, IServicesHandler servicesHandler) : base(exchangeConfiguration, servicesHandler)
        {

        }

        #region Public

        public override object GetTickersForConfiguredCoins()
        {
            throw new NotImplementedException();
        }

        public override object GetInvestedCoinBalances()
        {
            throw new NotImplementedException();
        }

        public override object GetOpenTrades()
        {
            throw new NotImplementedException();
        }

        public override object GetLastTradesForConfiguredCoins()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}