using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DatingApp.API.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        [NotNull]
        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; }
        [NotNull]
        [Column(TypeName = "nvarchar(20)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string City { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Region { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string PostalCode { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string Country { get; set; }
        [Column(TypeName = "nvarchar(24)")]
        public string HomePhone { get; set; }
        [Column(TypeName = "nvarchar(4)")]
        public string Extension { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string PhotoPath { get; set; }
        
        //public string ReportsTo { get; set; }
    }
}