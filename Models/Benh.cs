using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace QuanLyTiemChung_MVC_DOTNET.Models
{
    public class Benh
    {
        public Benh(){
            VacXins = new HashSet<PhongBenh>();
        }
        [Key]
        public string MaBenh{get; set;}
        public string TenBenh{get; set;}
        public string MoTa{get; set;}

        public virtual HashSet<PhongBenh> VacXins{get; set;}


    }
}