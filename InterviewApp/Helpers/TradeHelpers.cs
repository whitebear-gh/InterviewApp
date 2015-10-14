using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewApp.Entities;
using InterviewApp.Interfaces;

namespace InterviewApp.Helpers
{
    public class TradeHelpers
    {

        public static bool TryParseTrade(string[] cells,out ITrade resTrade )
        {
            resTrade = null;
            int id;
            if (false == int.TryParse(cells[0],out id))
            {                
                return false;
            }

            var trade = new Trade()
            {
                Id = int.Parse(cells[0]),
                MktPrice = double.Parse(cells[1]),
                Notional = double.Parse(cells[2]),
                Quantity = int.Parse(cells[3]),
                TradeDate = DateTime.Parse(cells[4]),
                TradeType = cells[5]

            };
            resTrade = trade;
            return true;
        }
    }
}
