using Strategy.Business.Interfaces;
using Strategy.Core.Cache;
using Strategy.Data;
using Strategy.Data.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business
{
    public class PassengerServiceFactory : IPassengerServiceFactory
    {
        private readonly IScenarioService _scenarioService;

        private readonly OfflinePassengerServiceStrategy _offlinePassengerServiceStrategy;
        private readonly OnlinePassengerServiceStrategy _onlinePassengerServiceStrategy;

        public PassengerServiceFactory(IScenarioService scenarioService,
            OfflinePassengerServiceStrategy offlinePassengerServiceStrategy,
            OnlinePassengerServiceStrategy onlinePassengerServiceStrategy)
        {
            _scenarioService = scenarioService;
            _offlinePassengerServiceStrategy = offlinePassengerServiceStrategy;
            _onlinePassengerServiceStrategy = onlinePassengerServiceStrategy;
        }

        public IPassengerService GetInstance()
        {
            switch (_scenarioService.Get())
            {
                case Core.Enums.Scenario.Offline:
                    return _offlinePassengerServiceStrategy;
                case Core.Enums.Scenario.Online:
                    return _onlinePassengerServiceStrategy;
                default:
                    throw new Exception();
            }
        }
    }
}
