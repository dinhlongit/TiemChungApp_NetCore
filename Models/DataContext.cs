using Microsoft.EntityFrameworkCore;

namespace QuanLyTiemChung_MVC_DOTNET.Models {
    public class DataContext : DbContext {
        public DataContext (DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<User> Users{get; set;}
        public DbSet<VacXin> VacXins { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Benh> Benhs { get; set; }
        public DbSet<PhongBenh> PhongBenhs { get; set; }
        public DbSet<LichSuTiemPhong> LichSuTiemPhongs { get; set; }
        
    }
  
    }
    
