﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using TodoClient.Models;

namespace TodoWithLoginFeature.Models
{
    public class User
    {
        public string Username { get; set; }
        public int UserID { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public int SecurityLevel { get; set; }
        public string Role { get; set; }
        public int Birthday { get; set; }
        public IList<Todo> Todos { get; set; }
        

        public void addTodo(Todo todo)
        {
            Todos.Add(todo);
        }
    }
}