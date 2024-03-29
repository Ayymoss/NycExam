﻿namespace NocoExam.Models;

public class ExamResult
{
    public string ExamName { get; }
    public Grade Grade { get; }

    public ExamResult(string examName, int score)
    {
        ExamName = examName;
        Grade = score switch
        {
            >= 90 => Grade.A,
            >= 80 => Grade.B,
            >= 70 => Grade.C,
            >= 60 => Grade.D,
            _ => Grade.F
        };
    }
}

public enum Grade
{
    A,
    B,
    C,
    D,
    F
}
