﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace UniProject
{
    public class Programmer : Student
    {
        public Programmer(string university, string faculty, string hometown,
                            bool isFullTime, string name, string surname, int age, uint semestersAmount)
                 : base(university, faculty, hometown, isFullTime, name, surname, age, semestersAmount)
        {
        }

        public override bool NotPassedAllExams()
        {
            if (RecordBook.ExamResults.Average(result => result.Mark) < 4)
                return true;
            return false;
        }

        protected override void AddSubjects()
        {
            Subjects = new List<ISubject>();
            List<ISubject> subjects = new List<ISubject>() { new SubjectWithoutExam("Logic"),
                                                             new SubjectWithoutExam("Rodnaja Mova"),
                                                             new SubjectWithExam("C# language"),
                                                             new SubjectWithExam("C++ language"),
                                                             new SubjectWithExam("Math") };
            Subjects.AddRange(subjects);
        }
    }
}
