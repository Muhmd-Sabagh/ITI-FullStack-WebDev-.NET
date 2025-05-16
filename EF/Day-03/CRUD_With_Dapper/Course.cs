namespace CRUD_With_Dapper
{
    class Course
    {
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public int Crs_Duration { get; set; }
        public int Top_Id { get; set; }

        public Topic Topic { get; set; }

        public override string ToString()
        {
            return $"Course Id: {Crs_Id}, Course Name: {Crs_Name}, Course Duration {Crs_Duration}H, Topic_Id:{Topic.Top_Name}";
        }
    }
}
