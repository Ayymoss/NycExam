using NocoExam.Models;

namespace NocoExam;

public static class NocoExam
{
    public static void Main()
    {
        // Used just to fill with test data
        var students = new StudentModel[5];

        for (var i = 0; i < students.Length; i++)
        {
            students[i] = new StudentModel("Rivers, John", 21);
            students[i].AddExamResult(new ExamResultModel("Math", 54));
            students[i].AddExamResult(new ExamResultModel("English", 94));
            students[i].AddExamResult(new ExamResultModel("Science", 62));

            students[i].PrintInfo();
        }
    }
}
