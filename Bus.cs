namespace Seminar1
{
    class Bus
    {
        public static int count = 20;

        public static void FillTableBus()
        {
            string text = "id;StateNumber;PassengerCapacity;RouteID;DriverID;ConductorID;\n";

            string[] passenger = { "Small", "Medium", "Large" };
            List<int> listOfDriversID = ListOfDriversID();
            List<int> listOfConductorsID = ListOfConductorsID();
            int conductorID = 2;

            Random random = new Random();
            for (int id = 1; id <= count; id++)
            {
                int stateNumber = 100 + id * 20 + random.Next(1, 10);
                int route = random.Next(1, 21);
                string passengerCapacity = passenger[random.Next(passenger.Length)];
                if (passengerCapacity == "Small")
                    conductorID = 1;
                else
                    conductorID = listOfConductorsID[id - 1];
                text +=
                    $"{id};{stateNumber};{passengerCapacity};{route};{listOfDriversID[id - 1]};{conductorID};\n";
            }

            File.WriteAllText("bus.csv", text);
        }

        private static List<int> ListOfDriversID()
        {
            List<int> list = new List<int>();
            while (list.Count != count)
            {
                list.Add(new Random().Next(1, Driver.count + 1));
                list = list.Distinct().ToList();
            }
            return list;
        }

        private static List<int> ListOfConductorsID()
        {
            List<int> list = new List<int>();
            while (list.Count != count)
            {
                list.Add(new Random().Next(2, Conductor.count + 1));
                list = list.Distinct().ToList();
            }
            return list;
        }
    }
}
