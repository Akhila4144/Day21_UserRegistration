﻿using System;

namespace UserRegexExceptionHandlingUC8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User Registration  ");
            string Password;
            Console.Write("Enter Password : ");
            Password = Console.ReadLine();
            Pattern.CheckPassword(Password);


            Console.ReadKey();
        }
    }
    }

