using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Fund
{
  // NOTE: This code copied from HETransaction, will be reused once the APIs are built
  public class FundDto
  {
    public FundDto()
    {
      TradingActivityDetail = new List<TradingActivityDetailDto>();
      PendingTrades = new List<PendingTradeDto>();
    }
    public string Fund { get; set; }
    public string SubaccountId { get; set; }
    public string Symbol { get; set; }
    public string BestSymbol { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string Category { get; set; }
    public string AssetClass { get; set; }
    public string MgtStyle { get; set; }
    public bool IsPremium { get; set; }
    public bool IsInvestorChoice { get; set; }
    public bool IsPassive { get; set; }
    public decimal? Stat1Yr { get; set; }
    public decimal? Stat3Yr { get; set; }
    public decimal? Stat5Yr { get; set; }
    public decimal OER { get; set; }
    public DateTime StatAsOfDate { get; set; }
    public decimal Shares { get; set; }
    public decimal StartingPrice { get; set; }
    public decimal ClosingPrice { get; set; }
    public decimal ClosingValue { get; set; }
    public string UrlResearch { get; set; }
    public string UrlProspectus { get; set; }
    public TradingStatusDto TradingStatus { get; set; }
    public TradingActivityDto TradingActivity { get; set; }
    public List<TradingActivityDetailDto> TradingActivityDetail { get; set; }
    public PendingTradeDto PendingTrade { get; set; }
    public List<PendingTradeDto> PendingTrades { get; set; }
  }

  // NOTE: This code copied from HETransaction, will be reused once the APIs are built
  public class TradingStatusDto
  {
    public decimal PendingTradesCount { get; set; }
    public decimal PendingTrades { get; set; }
    public decimal EstimatedValue { get; set; }
    public decimal EstimatedHolding { get; set; }
    public int TargetHolding { get; set; }
    public bool ClosedforInvestment { get; set; }
    public DateTime? ClosedforInvestmentDate { get; set; }
    public bool AvailableForReplacement { get; set; }
    public DateTime? FundOpenedDate { get; set; }
  }

  // NOTE: This code copied from HETransaction, will be reused once the APIs are built
  public class TradingActivityDto
  {
    public DateTime FundReportStartDate { get; set; }
    public DateTime FundReportEndDate { get; set; }
    public decimal BeginningBalance { get; set; }
    public decimal Trades { get; set; }
    public decimal Dividends { get; set; }
    public decimal OtherGains { get; set; }
    public decimal EndingBalance { get; set; }
    public decimal EndingShares { get; set; }
    public double? Return { get; set; }
  }

  // NOTE: This code copied from HETransaction, will be reused once the APIs are built
  public class TradingActivityDetailDto
  {
    public DateTime FundTransactionDate { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal Amount { get; set; }
    public decimal Shares { get; set; }
    public decimal TotalShares { get; set; }
    public decimal TotalValue { get; set; }
  }

  // NOTE: This code copied from HETransaction, will be reused once the APIs are built
  public class PendingTradeDto
  {
    public DateTime Submitted { get; set; }
    public string TradeId { get; set; }
    public string Action { get; set; }
    public decimal Amount { get; set; }
    public decimal Shares { get; set; }
    public ScheduledItemStatusEnum Status { get; set; }
    public bool ShareTrade { get; set; }
    public bool PreventMemberCancel { get; set; }
    public bool TradeDependentOnHold { get; set; }
  }

  // NOTE: This code copied from HEData, will be reused once the APIs are built
  public enum ScheduledItemStatusEnum
  {
    None = 0,
    NeedsApproval = 1,
    Pending = 2,
    Executing = 3,
    Completed = 4,
    Failed = 5,
    Cancelled = 6
  }

}
