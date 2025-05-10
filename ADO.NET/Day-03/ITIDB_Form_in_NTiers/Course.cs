using System.Data;

namespace ITIDB_Form_in_NTiers
{
    class Course
    {
        // Select All
        public static DataTable GetAllCourses()
        {
            return DBQuery.Select("SELECT * FROM Course");
        }

        // Select By ID
        public static DataTable GetCourseByID(int id)
        {
            return DBQuery.Select($"SELECT * FROM Course WHERE Crs_Id={id}");
        }

        // Add Course
        public static int AddCourse(int id, string name, int duration, int topicID)
        {
            return DBQuery.DML($"INSERT INTO Course VALUES ({id}, '{name}', {duration}, {topicID})");
        }

        // Update Course
        public static int UpdateCourse(int id, string name, int duration, int topicID)
        {
            return DBQuery.DML($"UPDATE Course SET Crs_Name='{name}', Crs_Duration={duration}, Top_Id={topicID} WHERE Crs_Id={id}");
        }

        // Delete Course
        public static int DeleteCourse(int id)
        {
            return DBQuery.DML($"DELETE FROM Course WHERE Crs_Id={id}");
        }
    }
}
