using Microsoft.AspNetCore.Mvc;
using Strategy.Business;
using Strategy.Business.Interfaces;
using Strategy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.API.Controllers
{
    [Route("[controller]")]
    public class ScenarioController : ControllerBase
    {
        private readonly IScenarioService _scenarioService;

        public ScenarioController(IScenarioService scenarioService)
        {
            _scenarioService = scenarioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_scenarioService.Get());
        }

        [HttpPut]
        public IActionResult Update(Enums.Scenario scenario)
        {
            _scenarioService.Update(scenario);
            return Ok();
        }
    }
}
