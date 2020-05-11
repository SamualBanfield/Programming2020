using System;
using System.Collections.Generic;

namespace Classes
{
  class Program
  {
    static void Main(string[] args)
    {

      for (; ; )
      {
        Console.Write(@"Do you wish to run...
1. Cookie Class
2. Person Class
3. Student/Subject Class
");
        char selection = Convert.ToChar(Console.ReadLine());
        if (selection == '1')
        {
          Task1();
        }
        if (selection == '2')
        {
          Task2();
        }
        if (selection == '3')
        {
          Task3();
        }
        if (selection == 'x')
        {
          break;
        }
        Console.WriteLine();
      }
    }
    static void Task1()
    {
      var cookie_1 = new Cookie(10, "square", new Colour("blue"));
      var cookie_2 = new Cookie(8, "circle", new Colour("red"));
      var cookie_3 = new Cookie(8, "circle", new Colour("green"));
      Cookie[] cookies = new Cookie[] { cookie_1, cookie_2, cookie_3 };
      foreach (Cookie cookie in cookies)
      {
        cookie.bake();
      }
    }
    static void Task2()
    {
      var rnd = new Random();
      var person_1 = new Person("Sam", "Banfield", new DateTime(2000, 5, 9), 229, rnd.Next(1000, 9999));
      var person_2 = new Person("Mike", "Tomas", new DateTime(1999, 3, 1), 150, rnd.Next(1000, 9999));
      Console.WriteLine("My name is {0}", person_1.getFullName());
      Console.WriteLine("Height difference between {0} & {1} is: {2}", person_1, person_2, person_1.getHeightDifference(person_2));
    }
    static void Task3()
    {
      var student_1 = new Student("Sam", "Banfield");
      var student_2 = new Student("Mike", "Tomas");
      var subject_1 = new Subject("Math_2020", new DateTime(2020, 2, 01));
      var subject_2 = new Subject("English_2021", new DateTime(2021, 2, 01));
      var subject_3 = new Subject("Science_Mid2020", new DateTime(2020, 5, 01));

      student_1.addSubject(subject_1);
      student_1.addSubject(subject_2);
      student_1.callSubjects();
    }
  }
  public class Cookie
  {
    public int weight;
    public string shape;
    public Colour colour;
    public Cookie(int argWeight, string argShape, Colour argColour)
    {
      weight = argWeight;
      shape = argShape;
      colour = argColour;
    }

    public void bake()
    {
      // I was originally trying to pass an array containing the rgb to be printed when bake occures but i was instead getting System.String[] and gave up on it.
      // Console.WriteLine("{0},{1},{2}", weight, shape, colour.printRGB());
      Console.WriteLine();
      Console.WriteLine(@"Weight: {0}
Shape: {1}", weight, shape);
      colour.printRGB();
    }
  }

  public class Colour
  {
    byte r = 0;
    byte g = 0;
    byte b = 0;
    public Colour(string selection)
    {
      switch (selection)
      {
        case "red":
          r = 255;
          break;
        case "green":
          g = 255;
          break;
        case "blue":
          b = 255;
          break;
        default:
          break;
      };
    }

    public void printRGB()
    {
      // My attempt, and it was returning a string[]
      // string[] returnArray = new string[] { r.ToString(), g.ToString(), b.ToString() };
      // return returnArray;
      Console.WriteLine("RGB: {0},{1},{2}", r, g, b);
    }
  }
  public class Person
  {
    public string firstName;
    public string surname;
    public DateTime DOB;
    public float height;

    public int id;

    public Person(string argfirstName, string argSurname, DateTime argDOB, float argHeight, int argId)
    {
      firstName = argfirstName;
      surname = argSurname;
      height = argHeight;
      DOB = argDOB;
      id = argId;
    }
    public string getFullName()
    {
      return (firstName + " " + surname);
    }
    public float getHeightDifference(Person stranger)
    {
      float result = height - stranger.height;
      return result;
    }
  }
  public class Student
  {
    public string firstName;
    public string surname;
    public List<string> subjects;
    public Student(string argFirstName, string argSurname)
    {
      firstName = argFirstName;
      surname = argSurname;
      subjects = new List<string>();
    }
    public void addSubject(Subject subject)
    {
      subjects.Add(subject.name);
    }
    public void callSubjects()
    {
      foreach (string sub in subjects)
      {
        Console.WriteLine(sub);
      }
    }
  }
  public class Subject
  {
    public string name;
    public DateTime yearOfDelivery;
    public Subject(string argname, DateTime argyearOfDelivery)
    {
      name = argname;
      yearOfDelivery = argyearOfDelivery;
    }
  }
}



