using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewApp.Helpers;
using InterviewApp.Interfaces;

namespace InterviewApp.Readers
{
    public class CSVReader : ITradeSource
    {
        private readonly string _fileName;
        private readonly char _separator;
        private FileStream _fileStream;

        public CSVReader(string fileName, char separator=',')
        {
            _fileName = fileName;
            _separator = separator;
        }

        public IEnumerable<ITrade> GetTrades()
        {
            if (false == File.Exists(_fileName))
            {
                throw new FileNotFoundException(_fileName);
            }

            var lines = File.ReadLines(_fileName);
            var trades = lines.Select(line =>
            {
                var strings = line.Split(_separator);
                ITrade trade;
                if (TradeHelpers.TryParseTrade(strings, out trade))
                {
                    return trade;
                }
                return null;
            }).Where(trade => trade != null);
            return trades;

        }



    }




}
