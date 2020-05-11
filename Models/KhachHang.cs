using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace QuanLyTiemChung_MVC_DOTNET.Models
{
    public class KhachHang
    {

        public KhachHang(){
           VacXins = new HashSet<LichSuTiemPhong>();
       }
      [Key]
       public string MaKH{get; set;}
       public string HoTenKH{get; set;}
       public string SoDienThoai{get; set;}
       public string DiaChiKH{get; set;}
       public DateTime NgaySinh{get; set;}
       public bool GioiTinh{get ; set;}
       
       public virtual HashSet<LichSuTiemPhong> VacXins{get; set;}
       public virtual User User{get; set;}

    }
}