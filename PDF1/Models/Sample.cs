using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDF1.Models
{
    public class Sample
    {
        public int EmpId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }
        public string Status { get; set; }


        public List<Sample> GetSampleDetails()
        {

            List<Sample> samples = new List<Sample>();

            samples.Add(new Sample() { EmpId = 491, Name = "abc", Email = "abc@gmailcom", Country = "India", Status="Complianced" });
            samples.Add(new Sample() { EmpId = 492, Name = "xyz", Email = "xyz@gmail.com", Country = "India", Status= "Complianced" });
            samples.Add(new Sample() { EmpId = 493, Name = "mno", Email = "mno@gmail.com", Country = "India", Status = "Non-Complianced" });
            samples.Add(new Sample() { EmpId = 494, Name = "hjk", Email = "mno@gmail.com", Country = "India", Status= "Non-Complianced" });
            samples.Add(new Sample() { EmpId = 495, Name = "lop", Email = "mno@gmail.com", Country = "India", Status= "Partially-Complianced" });
            samples.Add(new Sample() { EmpId = 496, Name = "kop", Email = "mno@gmail.com", Country = "India", Status= "Partially-Complianced" });
            samples.Add(new Sample() { EmpId = 497, Name = "mqw", Email = "mno@gmail.com", Country = "India", Status= "Complianced" });
            samples.Add(new Sample() { EmpId = 498, Name = "fds", Email = "mno@gmail.com", Country = "India", Status= "Complianced" });
            samples.Add(new Sample() { EmpId = 499, Name = "erf", Email = "mno@gmail.com", Country = "India", Status= "Complianced" });
            samples.Add(new Sample() { EmpId = 500, Name = "trg", Email = "mno@gmail.com", Country = "India", Status= "Complianced" });

            return (samples);

        }
    }
}