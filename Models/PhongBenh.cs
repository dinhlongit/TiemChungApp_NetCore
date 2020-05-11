using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace QuanLyTiemChung_MVC_DOTNET.Models
{
    public class PhongBenh
    {
         [Key]
        public int id {get; set;}
         [ForeignKey("VacXin")]
        public string MaVacXin{get; set;}
         [ForeignKey("Benh")]
        public string MaBenh{get ; set;}
        public string GhiChu{get; set;}

        public VacXin VacXins{get; set;}
        public Benh Benhs{get; set;}

        

    }
}