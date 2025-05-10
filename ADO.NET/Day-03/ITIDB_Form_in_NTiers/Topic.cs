using System.Data;

namespace ITIDB_Form_in_NTiers
{
    class Topic
    {
        // Select All
        public static DataTable GetAllTopics()
        {
            return DBQuery.Select("SELECT * FROM Topic");
        }
    }
}
