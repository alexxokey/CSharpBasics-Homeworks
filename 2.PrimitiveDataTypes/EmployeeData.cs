using System;

class EmployeeData
{
    static void Main()
    {
        string firstName, familyName;
        byte age;
        char gender;
        long idNumber;
        ushort uniqueEmpNumber;

        firstName = "Alexandar";
        familyName = "Ivanov";
        age = 16;
        gender = 'm';
        idNumber = 8306112507;
        uniqueEmpNumber = 213;

        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Family Name: {0}", familyName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("ID number: {0}", idNumber);
        Console.WriteLine("Unique Employee Number: {0}", 27560000 + uniqueEmpNumber);
    }
}

