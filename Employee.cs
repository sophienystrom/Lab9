using System;

class Employee {

private string firstname;
private string lastname;
private string id;
private int age;
private string employmentstatus;

private string address;
private string phonenumber;
private string title;
private double yearlysalary;


public Employee() 
{
 firstname = "unknown";
 lastname = "unknown";
 id = "unknown";
 age = 0;
 employmentstatus = "active";
}

public Employee(string FS, string LS, string ID, int AGE) 
{
  firstname = FS;
  lastname = LS;
  id = ID;
  age = AGE;
  employmentstatus = "active";
}

public void Intro() 
{
  Console.WriteLine("Employee: " + firstname + " " + lastname);
  Console.WriteLine("Associated ID: " + id);
  Console.WriteLine("Current age: " + age);
  Console.WriteLine("Current employment status: " + employmentstatus);
}




























}