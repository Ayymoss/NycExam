namespace NocoExam.Models;

public class Student : Person
{
    private Guid StudentId { get; }
    private readonly ExamResult[] _examResult = new ExamResult[3];

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        StudentId = Guid.NewGuid();
    }

    public void AddExamResult(ExamResult examResult)
    {
        // This is trash but I have no idea how to do it better
        // Using a List<ExamResult> would have been a lot nicer - task calls for an Array, however.
        for (var i = 0; i < _examResult.Length; i++)
        {
            // Rider seems to think "_examResult[i] is not null" is always true, but it's not...
            if (_examResult[i] is not null) continue;
            _examResult[i] = examResult;
            return;
        }

        Console.WriteLine("Exam array is full, throw an error or something");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, StudentId: {StudentId}");

        foreach (var examResult in _examResult.Where(exam => exam is not null))
        {
            Console.WriteLine($"Exam: {examResult.ExamName}, Grade: {examResult.Grade}");
        }
    }
}
