using EVCalculatorAPI.Types;
using EVCalculatorAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EVCalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EfficiencyController : ControllerBase
    {
        private readonly IEfficiencyProcessor _processor;

        public EfficiencyController(IEfficiencyProcessor processor)
        {
            _processor = processor;
        }

        // POST api/<EfficiencyController>
        [HttpPost]
        public Efficiency Post([FromBody] EfficiencyInput data)
        {
            Efficiency result = _processor.GetEfficiencyCalculations(data.value, data.unit);
            return result;

        }



    }
}
