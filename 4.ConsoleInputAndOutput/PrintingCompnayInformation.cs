using System;

class PrintingCompnayInformation
{
    static void Main()
    {
        string compName = "Comapny name:" ;
        string compAdress = "Company address: ";
        string phoneNum = "Phone number: ";
        string faxNum = "Fax number: ";
        string manager1st = "Manager first name: ";
        string managerLast = "Manager last name: ";
        string managerOld = "Manager age: ";
        string managerNum = "Manager phone: ";
        string web = "Web site: ";

        string name = "Software University";
        string companyAdress = "26 V. Kanchev, Sofia";
        string phoneNumber = "+ 359 899 55 55 92";
        string faxNumber = "No Fax";
        string webSite = "http://softuni.bg";
        string managerFirstName = "Svetlin";
        string managerLastName = "Nakov";
        int managerAge = 25;
        string managerPhone = "+359 2 981 981";
        
        Console.WriteLine("{0, -20} | {1, 20}", compName, name);
        Console.WriteLine("{0, -20} | {1, 20}", compAdress, companyAdress);
        Console.WriteLine("{0, -20} | {1, 20}", phoneNum, phoneNumber);
        Console.WriteLine("{0, -20} | {1, 20}", faxNum, faxNumber);
        Console.WriteLine("{0, -20} | {1, 20}", web, webSite);
        Console.WriteLine("{0, -20} | {1, 20}", manager1st, managerFirstName);
        Console.WriteLine("{0, -20} | {1, 20}", managerLast, managerLastName);
        Console.WriteLine("{0, -20} | {1, 20}", managerOld, managerAge);
        Console.WriteLine("{0, -20} | {1, 20}", managerNum, managerPhone);
        
    }
}

