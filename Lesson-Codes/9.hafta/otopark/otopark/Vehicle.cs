using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark
{
    class Vehicle
    {
        public VehicleTypes Type { get; set; }
        public int Size { get; set; }
        public string PlateNumber { get; set; }
        public Vehicle(string plateNumber, VehicleTypes type)
        {
            PlateNumber = plateNumber;
            Type = type;
            Size = DefaultSize(Type);
        }
        public Vehicle(string plateNumber,VehicleTypes type,int size)
        {
            PlateNumber = plateNumber;
            Type = type;
            Size = size;
        }
        private int DefaultSize(VehicleTypes type)
        {
            switch(type)
            {
                case VehicleTypes.Automobile:
                    return 2;
                case VehicleTypes.Motocycle:
                    return 1;
                case VehicleTypes.Truck:
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
