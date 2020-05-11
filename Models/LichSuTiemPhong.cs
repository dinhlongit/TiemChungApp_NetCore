using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace QuanLyTiemChung_MVC_DOTNET.Models
{
    public class LichSuTiemPhong
    {


        [Key]
        public int id {get; set;}
        [ForeignKey("KhachHang")]
        public string MaKH {get; set;}
        [ForeignKey("VacXin")]
        public string MaVacXin{get; set;}
        public string STTMui{get; set;}

         
        public DateTime NgayTiemPhong{get; set;}
        public DateTime NgayHenTiepTheo{get; set;}

        public KhachHang KhachHangs{get; set;}
        public VacXin VacXins{get; set;}
    }
}