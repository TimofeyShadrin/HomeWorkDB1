namespace Seminar1
{
    class Routes
    {
        public static void NumbersOfRoutes()
        {
            string text = "id;NumberOfRoute;\n";

            int count = 20;

            for (int id = 1; id <= count; id++)
            {
                int numberOfRoute = 100 + id * 10 + id;
                text += $"{id};{numberOfRoute};\n";
            }

            File.WriteAllText("Routes.csv", text);
        }
    }
}
