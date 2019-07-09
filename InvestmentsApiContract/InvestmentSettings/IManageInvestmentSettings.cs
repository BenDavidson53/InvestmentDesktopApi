using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsApiContract.InvestmentSettings
{
  public interface IManageInvestmentSettings
  {
    string UpdateAutoInvestSettings(AutoInvestSettingsDto dto);
    string UpdateAutoRebalanceSettings(AutoRebalanceSettingsDto dto);
    InvestmentSettingsDto GetMemberInvestmentSettings();
    bool IsNewInvestmentFlowAccessible();
  }
}
