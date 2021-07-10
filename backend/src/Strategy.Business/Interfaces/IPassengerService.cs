using Strategy.Core;
using Strategy.Data;

using Strategy.Data.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business.Interfaces
{
    public interface IPassengerService
    {
        Passenger Create(PassengerRequest request);
        Passenger Update(PassengerRequest request);
        Passenger Get(GetPassengerRequest request);
        void Delete(DeletePassengerRequest request);
    }
}
