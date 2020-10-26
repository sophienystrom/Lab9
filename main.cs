using System;

class MainClass {
  public static void Main (string[] args) {
    
  Employee employee2 = new Employee("John", "Smith", "1234", 45);
  employee2.Intro(); 

  Console.WriteLine(" "); // I just wanted the spacing

  Employee employee1 = new Employee();
  employee1.Intro();





  }
}