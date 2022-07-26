namespace Seminar1
{
    class Conductor
    {
        public static int count = 30;

        public static void FillTableConductor()
        {
            string text = "id;fName;lName;dateOfBirth;ITN;\n";

            Random random = new Random();
            int id = 1;
            text += $"{id};None;\n";
            for (id = 2; id <= count; id++)
            {
                string fName = $"Иия_{id - 1}";
                string lName = $"Фамилия_{id - 1}";
                int dateOfBirth = random.Next(1962, 2004);
                string itn = $"ITN{id - 1}";
                text += $"{id};{fName};{lName};{dateOfBirth};{itn};\n";
            }
            File.WriteAllText("conductor.csv", text);
        }
    }
}
