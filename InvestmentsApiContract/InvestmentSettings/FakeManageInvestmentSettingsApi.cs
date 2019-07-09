using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.InvestmentSettings
{
  public class FakeManageInvestmentSettingsApi : IManageInvestmentSettings
  {
    public InvestmentSettingsDto GetMemberInvestmentSettings()
    {
      throw new NotImplementedException();
    }

    public bool IsNewInvestmentFlowAccessible()
    {
      throw new NotImplementedException();
    }

    public string UpdateAutoInvestSettings(AutoInvestSettingsDto dto)
    {
      throw new NotImplementedException();
    }

    public string UpdateAutoRebalanceSettings(AutoRebalanceSettingsDto dto)
    {
      throw new NotImplementedException();
    }
  }
}
