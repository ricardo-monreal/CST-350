﻿namespace AjaxExample.Models
{
    public class CustomerModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public CustomerModel(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
