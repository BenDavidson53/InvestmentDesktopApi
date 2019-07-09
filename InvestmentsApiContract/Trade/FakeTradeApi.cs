using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Trade
{
  public class FakeTradeApi : ITrade
  {
    public string BuyFund(CreateTradeDto dto)
    {
      return AddTrade(dto);
    }

    public string BuyFunds(List<CreateTradeDto> dtos)
    {
      string result = "";

      foreach (CreateTradeDto dto in dtos)
      {
        result += BuyFund(dto);
      }

      return result;
    }

    public string CancelTrade(string tradeId)
    {
      // In order to cancel a trade, alls you needs is a scheduled item id, specifically a scheduled trade id
      // Take a look at TradeHistoryStyled.ascx.cs (file), TradeHistoryStyled (class), CancelTrade() (method)
      // TODO: Do we need an API for cancel all trades?

      return "";
    }

    public List<TradeDto> GetMemberCancelledTrades()
    {
      throw new NotImplementedException();
    }

    public List<TradeDto> GetMemberPendingTrades()
    {
      throw new NotImplementedException();
    }

    public string SellFund(CreateTradeDto dto)
    {
      // don't forget the extra steps for selling funds!
      return AddTrade(dto);
    }

    public string SellFunds(List<CreateTradeDto> dtos)
    {
      string result = "";

      foreach (CreateTradeDto dto in dtos)
      {
        result += SellFund(dto);
      }

      return result;
    }

    private string AddTrade(CreateTradeDto dto)
    {
      /*       
       Creating a trade at HealthEquity happens by executing XAddScheduledTrade
       Take a look at TradeStyled.ascx.cs (file), TradeStyled (class), btnExecuteTrades_Click() (method) 
       for an example of executing XAddScheduledTrade
       */

      return "failure message or NULL";
    }
  }
}
