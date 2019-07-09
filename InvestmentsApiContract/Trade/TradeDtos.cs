using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Trade
{
  public class CreateTradeDto
  {
    public string SubaccountId { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
  }

  public class TradeDto
  {
    // send "Can Cancel" data
  }
}
