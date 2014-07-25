using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace GeraçãoMetaStockFiles
{
    public class clsStock
    {

            public string stock { get; set; }
            public string date { get; set; }
            public decimal open { get; set; }
            public decimal high { get; set; }
            public decimal low { get; set; }
            public decimal close { get; set; }
            public decimal volume { get; set; }
            public decimal open_int { get; set; }


            public clsStock(string stock, string date, string open, string high, string low, string close, string  volume, string open_int) 
            {
                this.stock = stock.Trim();

                DateTime dt = new DateTime(int.Parse(date.Substring(0, 4)) , int.Parse(date.Substring(4, 2)), int.Parse(date.Substring(6, 2)));
                this.date = dt.ToString("yyMMdd");

                this.open = decimal.Parse(open.Insert(open.Length - 2, "."), CultureInfo.InvariantCulture);
                this.high = decimal.Parse(high.Insert(high.Length - 2, "."), CultureInfo.InvariantCulture);
                this.low = decimal.Parse(low.Insert(low.Length - 2, "."), CultureInfo.InvariantCulture);
                this.close = decimal.Parse(close.Insert(close.Length - 2, "."), CultureInfo.InvariantCulture);
                this.volume = decimal.Parse(volume);
                this.open_int = decimal.Parse(open_int.Insert(open_int.Length - 2, "."), CultureInfo.InvariantCulture);
            }

    }

}
