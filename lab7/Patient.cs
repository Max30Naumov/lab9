﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace lab7
{
    [Serializable]
    public class Patient
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _id;

        //проверка на пустоту, null и другие символы
        [JsonPropertyName("FirstName")]
        public string FirstName { get => _firstName; set => _firstName = !string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value) && IsAlphaCharactersOnly(value) ? value : throw new ArgumentException("Имя не может быть пустым, null или содержать некорректные символы");}
        [JsonPropertyName("LastName")]
        public string LastName { get => _lastName; set => _lastName = !string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value) && IsAlphaCharactersOnly(value) ? value : throw new ArgumentException("Фамилия не может быть пустой, null или содержать некорректные символы");}
        [JsonPropertyName("Age")]
        public int Age { get => _age; set => _age = (value > 0 && value <= 100) ? value : throw new ArgumentException("Недопустимое значение возраста");}
        [JsonPropertyName("Id")]
        public int Id { get => _id; set => _id = value; }
        // регулярное выражение для проверки имени на содержание других символов
        private bool IsAlphaCharactersOnly(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Zа-яА-Я]+$");
        }
        public Patient(string firstname,string lastname, int age, int id)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Id = id;
        }

    }
}
