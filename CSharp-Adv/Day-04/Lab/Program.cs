namespace Collections
{
    #region Assignment
    /*
    1.	Try all what we have learned in the lecture
    2- Design and implement a class for the question  identified by(id , header , body)
    3- Design and implement a class for the answer  identified by(id , answer )
    4-Implement All the Necessary Member Functions on the Class
    6-Design a class to represent the Question list by inheriting the List<> class
    7-Override the Add Method, keep the default behavior for the Add Method and add logic to open a file
      and Log the Questions in it, every Question Object of Question List will be logged to a Same file
      each Question List has Different File(help on TextWrite and TextReader Class).
    16-	Define dictionary to represent Csharp exam, dictionary item contain(question , list<answer>)
    17-	Print Csharp exam
    */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Add and Log Questions List
            string[] questions = {
            "1. This is a Lion.",
            "2. This is a Table.",
            "3. This is an Elephant."
            };
            Question q1 = new Question(1, "True Or False:", questions);
            Question q2 = new Question(2, "Chose The Correct Answer:", questions);
            Question q3 = new Question(3, "Answer these Questions:", questions);

            //QuestionList qList = new QuestionList("file1.txt");
            //qList.Add(q1);
            //qList.Add(q2);

            //QuestionList qList2 = new QuestionList("file2.txt");
            //qList2.Add(q3);
            #endregion

            #region CSharp Exam Dictionary
            // Dictionary of Questions and Answers
            List<Answer> q1Answers = new List<Answer>() { new Answer(1, "True"), new Answer(2, "False"), new Answer(2, "False") };
            List<Answer> q2Answers = new List<Answer>() { new Answer(1, "Dog"), new Answer(2, "Cat"), new Answer(2, "Elephant") };
            List<Answer> q3Answers = new List<Answer>() { new Answer(1, "Yes"), new Answer(2, "No"), new Answer(2, "Yes") };
            Dictionary<Question, List<Answer>> CSExam = new Dictionary<Question, List<Answer>>() {
                { q1, q1Answers },
                { q2, q2Answers },
                { q3, q3Answers }
            };

            foreach (KeyValuePair<Question, List<Answer>> keyValuePair in CSExam)
            {
                Console.WriteLine(keyValuePair.Key);
                foreach (Answer answer in keyValuePair.Value)
                    Console.WriteLine(answer);
                Console.WriteLine("-----------------");
            } 
            #endregion
        }
    }
}
