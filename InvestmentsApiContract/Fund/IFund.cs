using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Fund
{
  public interface IFund
  {
    List<FundDto> GetAvailableFunds(string investmentSourceSubaccountId);
  }
}
