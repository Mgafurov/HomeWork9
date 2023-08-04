using System;

class Program
{
    static void Main()
    {
        InsuranceCompany insuranceCompany = new InsuranceCompany("Страховая компания", "ул.Бобура 1", "Автострахование");
        ShipbuildCompany shipbuildCompany = new ShipbuildCompany("Судостроительная компания", "ул.Шевченок", 2000);
        Factory factory = new Factory("Завод", "ул.Ленина", "Машиностроение");
        Library library = new Library("Библиотека", "ул.Космонавтов", 1000000);

        Organization[] organizations = { insuranceCompany, shipbuildCompany, factory, library };

        Console.WriteLine("Огранизации: ");
        foreach (var organization in organizations)
        {
            Console.WriteLine(organization.GetInfo());
        }
        Console.ReadLine();
    } 
}