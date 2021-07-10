using Strategy.Business.Interfaces;
using Strategy.Core;
using Strategy.Core.Cache;
using Strategy.Data;
using Strategy.Data.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business
{
    public class PassengerService : IPassengerService
    {
        private readonly ICacheService _cacheService;
        private readonly Enums.Scenario _activeScenario;

        public PassengerService(ICacheService cacheService, IScenarioService scenarioService)
        {
            _cacheService = cacheService;
            _activeScenario = scenarioService.Get();
        }

        public Passenger Create(PassengerRequest request)
        {
        }
        public Passenger Update(PassengerRequest request)
        {
            var passenger = _cacheService.Get<Passenger>($"{_activeScenario}:{request.Passenger.UniquePassengerId}");
            if (passenger is null) throw new Exception("Passenger not found");

            var result = _cacheService.Set($"{_activeScenario}:{request.Passenger.UniquePassengerId}", request.Passenger);
            return (Passenger)result;
        }

        public void Delete(DeletePassengerRequest request)
        {
            _cacheService.Clear($"{_activeScenario}:{request.PassengerId}");
        }

        public Passenger Get(GetPassengerRequest request)
        {
            return _cacheService.Get<Passenger>($"{_activeScenario}:{request.PassengerId}");
        }

        public List<Passenger> GetAll()
        {
            _cacheService.GetList<Passenger>($"{_activeScenario}");
        }
    }
}
