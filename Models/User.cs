using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTiemChung_MVC_DOTNET.Models
{
    public class User
    {
        [Key]
        public string username{get; set;}
        public string password{get; set;}

         [ForeignKey("KhachHang")]
        public string MaKH{get; set;}

        public virtual KhachHang KhachHang{get; set;}

        
    }
}