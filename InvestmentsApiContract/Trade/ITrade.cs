using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Trade
{
  public interface ITrade
  {
    string BuyFund(TradeDto dto);

    string BuyFunds(List<TradeDto> dtos);

    string SellFund(TradeDto dto);

    string SellFunds(List<TradeDto> dto);

    List<TradeDto> GetMemberTrades();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="tradeId"></param>
    /// <returns>In case of a success, returns null. In case of an error, returns a user friendly error message.</returns>
    string CancelTrade(string tradeId);
  }
}
