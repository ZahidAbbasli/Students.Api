﻿namespace Students.Logic.Models.Students
{
  public class Student//TODO: add validation attributes
  {
    public int Id { get; set; }
    public Gender Gender { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Patronymic { get; set; }
    public string UId { get; set; }
  }
}
