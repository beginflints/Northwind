using Northwind.API.Models;

namespace Northwind.API.ViewModels
{
    public class EmployeeViewModel : Employee
    {
        public string Displayname { 
            get{return FirstName + LastName;}}
    }
}