using System.Xml.Linq;

namespace LINQLab01Answers
{
    class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = "";
        public string LName { get; set; } = "";
        public int Age { get; set; }
        public int Salary { get; set; }
        public int TrackId { get; set; }

        public override string ToString()
        {
            return $"Student Id: {Id}, Name: {FName} {LName}, Age: {Age}, Salary: {Salary}, Track: {TrackId}";
        }
    }
}
