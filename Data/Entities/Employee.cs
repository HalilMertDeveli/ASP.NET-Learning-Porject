﻿namespace AspNetEntity.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class PartTimeEmployee : Employee
    {
        public decimal DailtWage { get; set; }  
    }
    public class FullTimeEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
    }
}
