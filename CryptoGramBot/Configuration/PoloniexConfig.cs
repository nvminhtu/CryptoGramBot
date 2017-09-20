﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoGramBot.Configuration
{
    public class PoloniexConfig
    {
        public bool Enabled { get; set; }
        public string Key { get; set; }
        public string Secret { get; set; }
        public bool TradeNotifications { get; set; }
    }
}