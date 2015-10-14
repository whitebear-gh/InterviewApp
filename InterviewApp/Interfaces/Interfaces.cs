using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.Interfaces
{
    public interface ITrade
    {
        int Id { get; set; }
        double MktPrice { get; set; }
        double Notional { get; set; }
        int Quantity { get; set; }
        DateTime TradeDate { get; set; }
        string TradeType { get; set; }        
             
    }

    public interface ITradeSource
    {
        IEnumerable<ITrade> GetTrades();
    }


     
}
