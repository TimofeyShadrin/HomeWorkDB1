namespace Seminar1
{
    class Staff
    {
        public static void FillTableStaff()
        {
            string text = "id;fName;lName;dateOfBirth;ITN;\n";

            int count = 20;
            Random random = new Random();
            for (int id = 1; id <= count; id++)
            {
                string fName = $"Иия_{id}";
                string lName = $"Фамилия_{id}";
                int dateOfBirth = random.Next(1962, 2004);
                string itn = $"ITN{id}";
                text += $"{id};{fName};{lName};{dateOfBirth};{itn};\n";
            }
            File.WriteAllText("staff.csv", text);
        }
    }
}
