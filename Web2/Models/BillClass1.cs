using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace Web2.Models
{
    public enum BStatus
    {
        Bill_Inbox, Paid
    }
    public class BillClass1
    {
        [Key]
        public int bid { get; set; }

        [Display(Name = "Patient ID")]
        public int PatientId { get; set; }

        [Display(Name = "Patient Name")]
        public string pname { get; set; }

        [Display(Name = "Appointment Date")]
        public string Appointment { get; set; }

        [Display(Name = "Appointment Time")]
        public string AppointmentTime { get; set; }

        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Prescription")]
        [DataType(DataType.MultilineText)]
        public string Prescription { get; set; }

        [Display(Name = "Consulting Fees")]
        public int Amount { get; set; }

        [Display(Name = "Status")]
        public BStatus Status { get; set; }

        [Display(Name = "Consultant Name")]
        public string cname { get; set; }
    }

    public class billsDB : DbContext
    {
        public billsDB() : base("DefaultConnection")
        {

        }
        public DbSet<BillClass1> BillClass1s { get; set; }
    }

}