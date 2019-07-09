using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Trade
{
  public interface ITrade
  {
    string BuyFund(CreateTradeDto dto);

    string BuyFunds(List<CreateTradeDto> dtos);

    string SellFund(CreateTradeDto dto);

    string SellFunds(List<CreateTradeDto> dto);

    List<TradeDto> GetMemberPendingTrades();

    List<TradeDto> GetMemberCancelledTrades();

    string CancelTrade(string tradeId);
  }
}
