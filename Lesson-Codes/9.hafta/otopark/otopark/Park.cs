using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark
{
    class Park
    {
        int ParkSize = 20;
        Vehicle[] ParkingVehicle;

        public Park()
        {
            ParkingVehicle = new Vehicle[ParkSize];

        }
        public bool InsertNewVehicle(Vehicle vehicle,out int ticket)
        {
            ticket = -1;
            if (!(EmptySpace()) > vehicle.Size)
                return false;
            for (int i = 0; i < ParkingVehicle.Length; i++)
            {
                if(ParkingVehicle[i]==null || ParkingVehicle[i]==default(Vehicle))
                {
                    ParkingVehicle[i] = vehicle;
                    ticket = i;
                    break;
                }
            }
            return true;
        }
        public void LeftPark(int ticketNumber)
        {
            ShowPayment(ParkingVehicle[ticketNumber]);
            ParkingVehicle[ticketNumber] = null;
        }
        public int EmptySpace()
        {
            int total = 0;
            foreach (var vehicle in ParkingVehicle)
            {
                if (!(vehicle == null) || vehicle == default(Vehicle))
                    total += vehicle.Size;
            }
            return ParkSize - total;
        }
        public void ShowAllVehicles()
        {
            foreach (var vehicle in ParkingVehicle)
            {
                if (vehicle != null || vehicle != default(Vehicle))
                    Console.WriteLine("Plate number:{0}", vehicle.PlateNumber);
            }
        }
        private void ShowPayment(Vehicle vehicle)
        {
            double payment = 0;
            switch(vehicle.Type)
            {
                case VehicleTypes.Motocycle;
                    payment+=5;
                    payment+=(vehicle.Size-1)*1;
                    break;
                     case VehicleTypes.Automobile;
                    payment+=7;
                    payment+=(vehicle.Size-2)*3;
                    break;
                     case VehicleTypes.Truck;
                    payment+=10;
                    payment+=(vehicle.Size-3)*6;
                    break;
            }
            Console.WriteLine("payment: {0}",payment)
        }
        public bool TicketIsValid(int ticketNumber)
        {
            if (ticketNumber >= ParkSize)
                return false;
            if (ParkingVehicle[ticketNumber] == null || ParkingVehicle[ticketNumber] == default(Vehicle))
                return false;
            return true;
        }
    }
}
