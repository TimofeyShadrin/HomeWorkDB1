namespace Seminar1
{
    class Driver
    {
        public static int count = 30;

        public static void FillTableDriver()
        {
            string text = "id;fName;lName;dateOfBirth;ITN;\n";

            Random random = new Random();
            for (int id = 1; id <= count; id++)
            {
                string fName = $"Иия_{id}";
                string lName = $"Фамилия_{id}";
                int dateOfBirth = random.Next(1962, 2004);
                string itn = $"ITN{id}";
                text += $"{id};{fName};{lName};{dateOfBirth};{itn};\n";
            }
            File.WriteAllText("driver.csv", text);
        }
    }
}
