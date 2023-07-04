using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Elevator.Controllers
{
    internal interface IElevatorFloorsController
    {
        //An elevator car requests all floors that it’s current passengers are servicing(e.g.to light up the buttons that show which floors the car is going to)
        public IEnumerable<string> GetFloorsCurrentlyServicing();

        ////An elevator car requests the next floor it needs to service
        public string GetNextFloorToService();
        public void RequestElevatorAtFloor(string floor);

        //A person requests that they be brought to a floor
        public void BringElevatorToFloor(string floor);

    }
}