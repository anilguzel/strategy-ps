using Microsoft.Extensions.DependencyInjection;
using Strategy.Business.Interfaces;
using Strategy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business
{
    public class ScenarioService : IScenarioService
    {
        private static Enums.Scenario _activeScenario;

        public Enums.Scenario Get()
        {
            return _activeScenario;
        }

        public void Update(Enums.Scenario scenario)
        {
            _activeScenario = scenario;
        }
    }
}
