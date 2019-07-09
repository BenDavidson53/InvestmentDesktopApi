using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Portfolio
{
  public interface IPortfolio
  {
    string AddFundToPortfolio(PortfolioFundDto dto);

    List<FundPerformanceDto> GetPortfolioPerformance(DateTime startDate, DateTime endDate);
    FundPerformanceDto GetFundPerformance(DateTime startDate, DateTime endDate, string fundId);
    List<FundActivity> GetFundActivity(string fundId);
    void DownloadFundActivity(string fundId);
    List<List<FundActivity>> GetPortfolioActivity();
    void DownloadPortfolioActivity();
  }
}
