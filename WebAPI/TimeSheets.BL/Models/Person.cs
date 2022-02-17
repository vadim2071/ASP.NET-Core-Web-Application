using System;


namespace TimeSheets.Models
{
    public class Person
    {
        public Person(string firstName, string lastName, string email, string company, int age)
        {
            Id = 0; //подумать откуда береться новое значение
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Company = company;
            Age = age;
        }

         public int Id { get; set; }
         public string FirstName { get; set; }
         public string LastName { get; set; }
         public string Email { get; set; }
         public string Company { get; set; }
         public int Age { get; set; }

    }
}
