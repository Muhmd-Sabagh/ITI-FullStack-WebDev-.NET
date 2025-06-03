namespace API_To_Form.DisplayModels
{
    internal class CourseData
    {
        // {"id":1,"crs_Name":"HTML","crs_Desc":"Frontend course","duration":10,"dept_Id":1,"dept":null}
        public int id { get; set; }
        public string crs_Name { get; set; }
        public string crs_Desc { get; set; }
        public int duration { get; set; }
        public int dept_Id { get; set; }
    }
}
