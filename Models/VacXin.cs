using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace QuanLyTiemChung_MVC_DOTNET.Models
{
    public class VacXin
    {
        public VacXin(){
            KhachHangs = new HashSet<LichSuTiemPhong>();
            Benhs = new HashSet<PhongBenh>();
        }
        [Key]
       public string MaVacXin {get; set;}
       public string TenVacXin{get; set;}
       public int SoMui{get; set;}
       public string MoTa{get; set;}
       public string TenHang{get; set;}

       public virtual HashSet<LichSuTiemPhong> KhachHangs{get; set;}
       public virtual HashSet<PhongBenh> Benhs{get; set;}


        
    }
}