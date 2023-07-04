using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elevator
{
    enum CarDirection
    {
        Up,
        Down
    };

    public class ElevatorInfo
    {
        static CarDirection carDirection = CarDirection.Up;

        private static string currentFloor;

        public static List<string> FloorOrder { get; set; } = new List<string>() {
          "A", "B", "C", "D", "1", "2", "3", "4", "5", "6" };

        public static List<string> DestinationList { get; set; } = new List<string>();

        public string GetNextFloorToService()
        {
            //Go there after figuring out elevator direction, and nearest next floor
            return DestinationList.FirstOrDefault();
        }
    }

}
