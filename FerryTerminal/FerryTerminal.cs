using System;
using System.Collections;
using System.Console;

namespace FerryTerminal
{
    class FerryTerminal
    {
        private static SmallFerry smallFerry;
        private static LargeFerry largeFerry;
        private int EmployeeSalary = 0;

        public FerryTerminal()
        {
            smallFerry = new SmallFerry();
            largeFerry = new LargeFerry();
        }

        public static void ReceiveVehicle(IVehicle vehicle)
        {
            vehicle.location = "Arrivals";
            Console.WriteLine(vehicle.location);
            EmployeeSalary += vehicle.ferryTicket.cost * 0.10;

            this.PushToFerry(vehicle);
        }

        private static void PushToFerry(IVehicle vehicle)
        {
            // Check if vehicle has gas
            if (vehicle.GetGasLevelRatio() < 10)
            {
                vehicle = PushToGasStation(vehicle);
            }

            // Check ferry type required
            if (vehicle.ferryType == FerryType.LargeFerry)
            {
                // Push to customs
                vehicle = PushToCustoms(vehicle);
            }

            // Push to Required Ferry
            if (vehicle.ferryType == FerryType.LargeFerry)
            {
                if (smallFerry.TryPush(vehicle))
                {
                    
                }
            }
            else
            {

            }
        }

        private static IVehicle PushToGasStation(IVehicle vehicle)
        {
            vehicle.location = "Gas Station";
            Console.WriteLine(vehicle.location);
            return vehicle;
        }

        private static IVehicle PushToCustoms(IVehicle vehicle)
        {
            vehicle.location = "Customs";
            Console.WriteLine(vehicle.location);
            if (!(vehicle as ILargeFerryVehicle).isCargoDoorOpen)
            {
                (vehicle as ILargeFerryVehicle).isCargoDoorOpen = true;
            }

            // Customs Inspection

            // Close Cargo Doors
            (vehicle as ILargeFerryVehicle).isCargoDoorOpen = false;

            return vehicle;
        }
    }
}