using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.Fund
{
  public class FakeFundApi : IFund
  {
    public List<FundDto> GetAvailableFunds(string subaccountId)
    {
      /* This method is modeled after TradeStyled.ascx.cs (file), TradeStyled (class), QueryDatabase (method)
      pseudo code of the current method

      IF the feature flag for portfolio agreements is on
        Use IInvestmentsService.GetFundsAvailableToEditInvestment, which requires member id and investment source subaccount id
      ELSE
        Use QInvestmentFundQuery, which requires member id and investment source subaccount id

      */
      return new List<FundDto>();
    }
  }
}
