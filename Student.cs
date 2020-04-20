using System;
using System.Collections.Generic;
// Student
// You must define a type for representing a student in code. A student can only be in one cohort at a time. A student can be working on many exercises at a time.
// Properties
// First name
// Last name
// Slack handle
// The student's cohort
// The collection of exercises that the student is currently working on <------------

namespace StudentExercises{
class Student {
  public Student(string first, string last, string slack, Cohort cohort){
    First = first;
    Last = last;
    Slack = slack;
    Cohort = cohort;
  }
  public string First{get; set;}
  public string Last{get; set;}
  public string Slack{get; set;}
  public Cohort Cohort{get; set;}

  

}
}