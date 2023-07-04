using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevatorFloorsController : ControllerBase, IElevatorFloorsController
    {
        //An elevator car requests all floors that its current passengers are servicing
        [HttpGet("current")]
        public IEnumerable<string> GetFloorsCurrentlyServicing()
        {
            return ElevatorInfo.DestinationList;
        }

        [HttpGet("next")]
        //An elevator car requests the next floor it needs to service
        public string GetNextFloorToService()
        {
            ElevatorInfo elevatorInfo = new ElevatorInfo();
            return elevatorInfo.GetNextFloorToService();
        }

        [HttpPut]
        [Route("{floor}/request")]
        //A person requests an elevator be sent to their current floor
        public void RequestElevatorAtFloor(string floor)
        {
            ElevatorInfo.DestinationList.Add(floor);
        }

        [HttpPut]
        [Route("{floor}/bring")]
        //A person requests that they be brought to a floor
        public void BringElevatorToFloor(string floor)
        {
            ElevatorInfo.DestinationList.Add(floor);
        }
    }
}
 