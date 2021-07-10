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
    public class OfflinePassengerServiceStrategy : IPassengerService
    {
        private readonly ICacheService _cacheService;

        public OfflinePassengerServiceStrategy(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        public Passenger Create(PassengerRequest request)
        {
            return (Passenger)_cacheService.Set($"{request.Passenger.UniquePassengerId}", request.Passenger);
        }
        public Passenger Update(PassengerRequest request)
        {
            var passenger = _cacheService.Get<Passenger>($"{request.Passenger.UniquePassengerId}");
            if (passenger is null) throw new Exception("Passenger not found");

            var result = _cacheService.Set($"{request.Passenger.UniquePassengerId}", request.Passenger);
            return (Passenger)result;
        }

        public void Delete(DeletePassengerRequest request)
        {
            _cacheService.Clear($"{request.PassengerId}");
        }

        public Passenger Get(GetPassengerRequest request)
        {
            return _cacheService.Get<Passenger>($"{request.PassengerId}");
        }
    }
}
