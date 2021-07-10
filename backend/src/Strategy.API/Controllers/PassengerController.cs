using Microsoft.AspNetCore.Mvc;
using Strategy.Business;
using Strategy.Business.Interfaces;
using Strategy.Data.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.API.Controllers
{
    [Route("[controller]")]
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerService _passengerService;

        public PassengerController(IPassengerServiceFactory passengerServiceFactory)
        {
            _passengerService = passengerServiceFactory.GetInstance();
        }

        [HttpPost]
        public IActionResult Create([FromBody] PassengerRequest request)
        {
            var result = _passengerService.Create(request);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] PassengerRequest request)
        {
            var result = _passengerService.Update(request);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Get([FromBody] GetPassengerRequest request)
        {
            var result = _passengerService.Get(request);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] DeletePassengerRequest request)
        {
            _passengerService.Delete(request);
            return Ok();
        }
    }
}
