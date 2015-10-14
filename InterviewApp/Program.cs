using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewApp.Interfaces;
using InterviewApp.Readers;

namespace InterviewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITradeSource csvSource = new CSVReader("file.csv");

            var trades = csvSource.GetTrades();
            
            foreach (var trade in trades.GroupBy(trade => trade.TradeType))
            {
                var sum = trade.Select(trade1 => trade1.Quantity * trade1.MktPrice).Sum();
                Console.WriteLine("{0}- {1}", trade.Key ,sum );
            }
            Console.ReadKey();
        }
    }
}
