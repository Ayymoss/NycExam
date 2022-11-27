namespace NocoExam.Models;

public class Student : Person
{
    private Guid StudentId { get; }
    private const int MaxExamResults = 3;
    private int _numExamResults;
    private readonly ExamResult[] _examResult = new ExamResult[MaxExamResults];

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        StudentId = Guid.NewGuid();
    }

    public void AddExamResult(ExamResult examResult)
    {
        if (_numExamResults >= MaxExamResults)
        {
            Console.WriteLine("Exam array is full, throw an error or something");
            return;
        }

        _examResult[_numExamResults++] = examResult;
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
