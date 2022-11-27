using NocoExam.Models;

namespace NocoExam;

public static class NocoExam
{
    public static void Main()
    {
        // Used just to fill with test data
        var students = new Student[5];

        for (var i = 0; i < students.Length; i++)
        {
            students[i] = new Student("Rivers, John", 21);
            students[i].AddExamResult(new ExamResult("Math", 54));
            students[i].AddExamResult(new ExamResult("English", 94));
            students[i].AddExamResult(new ExamResult("Science", 62));

            students[i].PrintInfo();
        }
    }
}
