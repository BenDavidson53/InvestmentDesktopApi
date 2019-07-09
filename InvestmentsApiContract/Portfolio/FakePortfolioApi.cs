using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Portfolio
{
  public class FakePortfolioApi : IPortfolio
  {
    public string AddFundToPortfolio(PortfolioFundDto dto)
    {
      throw new NotImplementedException();
    }

    public void DownloadFundActivity(string fundId)
    {
      throw new NotImplementedException();
    }

    public void DownloadPortfolioActivity()
    {
      throw new NotImplementedException();
    }

    public List<FundActivity> GetFundActivity(string fundId)
    {
      throw new NotImplementedException();
    }

    public FundPerformanceDto GetFundPerformance(DateTime startDate, DateTime endDate, string fundId)
    {
      throw new NotImplementedException();
    }

    public List<List<FundActivity>> GetPortfolioActivity()
    {
      throw new NotImplementedException();
    }

    public List<FundPerformanceDto> GetPortfolioPerformance(DateTime startDate, DateTime endDate)
    {
      throw new NotImplementedException();
    }
  }
}
