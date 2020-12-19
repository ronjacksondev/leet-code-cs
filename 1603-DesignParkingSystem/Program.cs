using System;

namespace _1603_DesignParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem(1,1,0);
            Console.WriteLine(parkingSystem.AddCar(1).ToString());
            Console.WriteLine(parkingSystem.AddCar(2).ToString());
            Console.WriteLine(parkingSystem.AddCar(3).ToString());
            Console.WriteLine(parkingSystem.AddCar(1).ToString());
        }
    }

    public class ParkingSystem
    {
        int bigParkingSpaces;
        int mediumParkingSpaces;
        int smallParkingSpaces;

        int bigSpacesUsed = 0;
        int mediumSpacesUsed = 0;
        int smallSpacesUsed = 0;

        public ParkingSystem(int big, int medium, int small)
        {
            bigParkingSpaces = big;
            mediumParkingSpaces = medium;
            smallParkingSpaces = small;
        }

        public bool AddCar(int carType)
        {
            bool isSpaceAvailable = false;
            if(carType == 1)
            {
                isSpaceAvailable = bigParkingSpaces > bigSpacesUsed;
                if (isSpaceAvailable)
                {
                    bigSpacesUsed++;
                }
            } else if(carType == 2)
            {
                isSpaceAvailable = mediumParkingSpaces > mediumSpacesUsed;
                if (isSpaceAvailable)
                {
                    mediumSpacesUsed++;
                }
            } else if(carType == 3)
            {
                isSpaceAvailable = smallParkingSpaces > smallSpacesUsed;
                if (isSpaceAvailable)
                {
                    smallSpacesUsed++;
                }
            }
            return isSpaceAvailable;
        }
    }

    /**
     * Your ParkingSystem object will be instantiated and called as such:
     * ParkingSystem obj = new ParkingSystem(big, medium, small);
     * bool param_1 = obj.AddCar(carType);
     */
}
