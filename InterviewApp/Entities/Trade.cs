using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewApp.Interfaces;

namespace InterviewApp.Entities
{
    class Trade :ITrade
    {
        public int Id { get; set; }
        public double MktPrice { get; set; }
        public double Notional { get; set; }
        public int Quantity { get; set; }
        public DateTime TradeDate { get; set; }
        public string TradeType { get; set; }
    }
}
