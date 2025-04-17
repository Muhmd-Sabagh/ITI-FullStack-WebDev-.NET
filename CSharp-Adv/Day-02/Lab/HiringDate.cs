namespace Lab
{
    class HiringDate : IComparable <HiringDate>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day = 0, int month = 0, int year = 0)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public override string ToString()
        {
            return $"Hiring Date: {Day}/{Month}/{Year}";
        }

        public int CompareTo(HiringDate? other)
        {
            if (Year == other.Year)
                if (Month == other.Month)
                    return Day.CompareTo(other.Day);
                else return Month.CompareTo(other.Month);
            return Year.CompareTo(other.Year);
        }
    }
}
