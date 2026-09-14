using Dictionary_Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dictionary_Project
{
    public class StudentData
    {
        public int LatestMark { get; set; }
        public int HighestMark { get; set; }
        public int TotalMark { get; set; }
        public int ExamCount { get; set; }
    }

    public class Student
    {
        private readonly Dictionary<string, StudentData> _student = new();

        public void AddMarks(string studentName, int marks)
        {

            if (marks < 0)
                throw new ArgumentException("Student mark must more & equal than 0");

            if (string.IsNullOrWhiteSpace(studentName))
                throw new ArgumentException("Student Name cannot be null or empty");

            if (_student.TryGetValue(studentName, out StudentData student))
            {
                student.LatestMark = marks;
                student.HighestMark = Math.Max(student.HighestMark, marks);
                student.TotalMark += marks;
                student.ExamCount += 1;

                return;
            }

            StudentData newStudent = new StudentData()
            {
                LatestMark = marks,
                HighestMark = marks,
                TotalMark = marks,
                ExamCount = 1
            };

            _student.Add(studentName, newStudent);
        }

        public int GetLatestMarks(string studentName)
        {
            if (!_student.TryGetValue(studentName, out StudentData student))
                throw new KeyNotFoundException("Invalid Student Name");

            return student.LatestMark;
        }

        public int GetHighestMarks(string studentName)
        {
            if (!_student.TryGetValue(studentName, out StudentData student))
                throw new KeyNotFoundException("Invalid Student Name");

            return student.HighestMark;
        }

        public double GetAverageMarks(string studentName)
        {
            if (!_student.TryGetValue(studentName, out StudentData student))
                throw new KeyNotFoundException("Invalid Student Name");

            return (double)student.TotalMark / student.ExamCount;
        }
    }
}


//1.Student Marks Manager
//Problem Statement

//Create a Student management system using a Dictionary.

//Each student has:

//Student Name
//Latest Marks
//Highest Marks
//Total Marks
//Number of Exams

//Implement:

//AddMarks(string studentName, int marks)
//GetLatestMarks(string studentName)
//GetHighestMarks(string studentName)
//GetAverageMarks(string studentName)