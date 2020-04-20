
using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Instructor
  {
    public Instructor(string first, string last, string slack, string specialty, Cohort cohort)
    {
      First = first;
      Last = last;
      Slack = slack;
      Specialty = specialty;
      Cohort = cohort;
    }

    public string First { get; set; }
    public string Last { get; set; }
    public string Slack { get; set; }
    public Cohort Cohort { get; set; }
    public string Specialty { get; set; }


    public void AssignExercise(Exercise exercise, Student student)
    {
      student.Exercises.Add(exercise);
    }
  }
}