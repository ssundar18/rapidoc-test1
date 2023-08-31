namespace rapi_doc
{
    public class Student
    {
        /// <summary>
        /// Name of the student
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Age of the student
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Birth date of the student
        /// </summary>
        public DateTime BirthDate => randomDate();
        //public string FatherName { get; set; }
        //public string MotherName { get; set; }
        //public string City { get; set; }

        private DateTime randomDate()
        {
            Random random = new Random();

            int year = random.Next(1900, 2101); // Generate a random year between 1900 and 2100
            int month = random.Next(1, 13);      // Generate a random month between 1 and 12
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1); // Generate a random day within the selected month

            DateTime randomDate = new DateTime(year, month, day);

            return randomDate;
        }
    }

    public class Staff
    {
        /// <summary>
        /// Name of the student
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Age of the student
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Birth date of the student
        /// </summary>
        public DateTime BirthDate => randomDate();
        //public string FatherName { get; set; }
        //public string MotherName { get; set; }
        //public string City { get; set; }

        private DateTime randomDate()
        {
            Random random = new Random();

            int year = random.Next(1900, 2101); // Generate a random year between 1900 and 2100
            int month = random.Next(1, 13);      // Generate a random month between 1 and 12
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1); // Generate a random day within the selected month

            DateTime randomDate = new DateTime(year, month, day);

            return randomDate;
        }
    }
}
