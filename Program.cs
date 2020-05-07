using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      Exercise ChickenMonkey = new Exercise("ChickenMonkey", "JavaScript");
      Exercise PlanYourHeist = new Exercise("Plan Your Heist", "C#");
      Exercise GlassdalePD = new Exercise("Glassdale PD", "JavaScript");
      Exercise Nutshell = new Exercise("Nutshell", "React");

      Cohort Day36 = new Cohort("Day Cohort 36");
      Cohort Day37 = new Cohort("Day Cohort 36");

      Student GuyC = new Student("Guy", "Cherkesky", "cherkesk", Day36);
      Student DanielF = new Student("Daniel", "Fuqua", "@Daniel Fuqua", Day37);
      Student HoldenP = new Student("Holden", "Parker", "@Holden Parker", Day36);
      Student MattC = new Student("Matt", "Crook", "@Matt Crook", Day36);
      Student DouieN = new Student("Douie", "Notheen", "@DoesNothing", Day36);

      Instructor JoeS = new Instructor("Joe", "Shepherd", "joeshep", "jokes", Day36);

      JoeS.AssignExercise(ChickenMonkey, HoldenP);
      JoeS.AssignExercise(GlassdalePD, HoldenP);
      JoeS.AssignExercise(Nutshell, HoldenP);
      JoeS.AssignExercise(ChickenMonkey, GuyC);
      JoeS.AssignExercise(GlassdalePD, GuyC);


      // ***************************** Phase 2 *****************************
      List<Student> students = new List<Student>() {
        GuyC,
        DanielF,
        HoldenP,
        MattC,
        DouieN
    };

      List<Exercise> exercises = new List<Exercise>() {
        ChickenMonkey,
        PlanYourHeist,
        GlassdalePD,
        Nutshell
    };

     List<Instructor> instructors = new List<Instructor>(){
         JoeS
     };


    List<Cohort> cohorts = new List<Cohort>(){
        Day36,
        Day37
    };
    
      // ***************************** Phase 2 *****************************
      Instructor SteveB = new Instructor("Steve", "Brownlee", "tech", "@coach", Day37);

      SteveB.AssignExercise(Nutshell, MattC);
      SteveB.AssignExercise(ChickenMonkey, MattC);

      var AllStudents = new List<Student>()
            {
                GuyC,
                DanielF,
                HoldenP,
                MattC,
                DouieN
            };

      var AllExercises = new List<Exercise>()
            {
                Nutshell,
                ChickenMonkey,
                GlassdalePD,
                PlanYourHeist
            };

      var AllInstructors = new List<Instructor>()
            {
                JoeS,
                SteveB,
            };

      var AllCohorts = new List<Cohort>()
            {
                Day37,
                Day36,
            };

      foreach (Student student in AllStudents)
      {
        foreach (Exercise exercise in student.Exercises)
        {
          Console.WriteLine($"{student.First} is working on the {exercise.Name} {exercise.Language} exercise in {student.Cohort.Name}.");
        }
      }

      var javaScriptExercises = AllExercises.Where(exercise => exercise.Language == "JavaScript");

      foreach (var exercise in javaScriptExercises)
      {
        Console.WriteLine($"JavaScript exercise: {exercise.Name}");
      }

      var day37Students = AllStudents.Where(student => student.Cohort == Day37);

      foreach (var student in day37Students)
      {
        Console.WriteLine($"Student in day cohort 37: {student.First} {student.Last}");
      }

      var day37Instructors = AllInstructors.Where(instructor => instructor.Cohort == Day37);

      foreach (var instructor in day37Instructors)
      {
        Console.WriteLine($"Instructor in day cohort 37: {instructor.First} {instructor.Last}");
      }

      var studentsByLastName = AllStudents.OrderBy(student => student.Last);

      Console.WriteLine("Students ordered by last name:");
      foreach (var student in studentsByLastName)
      {
        Console.Write($"{student.First} {student.Last} ");
      }

      var studentsNotWorking = AllStudents.Where(student => student.Exercises.Count() == 0);

      foreach (var student in studentsNotWorking)
      {
        Console.WriteLine($"Students not working on any exercises: {student.First} {student.Last}");
      }

      var descendStudentMostExercises = AllStudents.OrderByDescending(student => student.Exercises.Count());
      var studentMostExercises = descendStudentMostExercises.First();

      Console.WriteLine($"{studentMostExercises.First} {studentMostExercises.Last} is currently working on the most exercises.");

      var groups = AllStudents.GroupBy(student => student.Cohort.Name);
      foreach (var group in groups)
      {
        Console.WriteLine($"There are {group.Count()} students in {group.Key}.");
      }

    }
  }
}