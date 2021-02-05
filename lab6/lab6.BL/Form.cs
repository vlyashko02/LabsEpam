namespace lab6.BL
{
    struct Form
    {
        public string Surname { get; }
        public string Nationality { get; }
        public string Address { get; }
        public int FirstScore { get; }
        public int SecondScore { get; }
        public int ThirdScore { get; }

        public Form(string surname, string nationality, string address, int firstScore, int secondScore, int thirdScore)
        {
            Surname = surname;
            Nationality = nationality;
            Address = address;
            FirstScore = firstScore;
            SecondScore = secondScore;
            ThirdScore = thirdScore;
        }
    }
}
