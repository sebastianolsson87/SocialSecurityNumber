﻿using System;
using System.Globalization;

namespace SocialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

             
            Console.Write("Social Security Number (YYMMDD-XXXX): ");

            string socialSecurityNumber = Console.ReadLine();

            string gender = "Female";

            int genderNumber = int.Parse(socialSecurityNumber.Substring(socialSecurityNumber.Length - 2, 1));

            if (genderNumber % 2 != 0)
            {
                gender = "Male";
            }

            
            string dateNumber = socialSecurityNumber.Substring(0, 6);
            DateTime birthDate = DateTime.ParseExact(dateNumber, "yyMMdd", CultureInfo.InvariantCulture);

            int age = DateTime.Now.Year - birthDate.Year;

            if ((birthDate.Month > DateTime.Now.Month) || (birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day))
            {
                age--;
            }

            Console.WriteLine($"This person is {gender}, age {age}.");


            }
        }
    }
}