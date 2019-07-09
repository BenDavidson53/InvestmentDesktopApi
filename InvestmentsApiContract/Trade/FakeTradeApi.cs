using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Trade
{
  public class FakeTradeApi : ITrade
  {
    public string BuyFund(TradeDto dto)
    {
      throw new NotImplementedException();
    }

    public string BuyFunds(List<TradeDto> dtos)
    {
      throw new NotImplementedException();
    }

    public string CancelTrade(string tradeId)
    {
      throw new NotImplementedException();
    }

    public List<TradeDto> GetMemberTrades()
    {
      throw new NotImplementedException();
    }

    public string SellFund(TradeDto dto)
    {
      throw new NotImplementedException();
    }

    public string SellFunds(List<TradeDto> dto)
    {
      throw new NotImplementedException();
    }
  }
}
