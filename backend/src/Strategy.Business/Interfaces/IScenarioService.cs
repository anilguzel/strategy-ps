using Strategy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business.Interfaces
{
    public interface IScenarioService
    {
        Enums.Scenario Get();
        void Update(Enums.Scenario scenario);
    }
}
