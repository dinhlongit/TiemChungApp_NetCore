using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyTiemChung_MVC_DOTNET.Models;
using QuanLyTiemChung_MVC_DOTNET.ViewModel;


namespace QuanLyTiemChung_MVC_DOTNET.Service
{
    public interface IKhachHangService
    {
        public List<KhachHang> getKhachHangs();
      
           public KhachHang GetKhachHangById(string id);
           public void DeleteKhachHangById(string id);
   
         public void AddSKhachHang(KhachHang student);
         public List<LichSuKhachHang> getLichSuKhachHang(string id);

         public void updateKhachHang(KhachHang khachhang);
        public List<KhachHang> searchKhachHangByName(string keyword);
    }

    public class KhachHangService : IKhachHangService
    {
        private DataContext _context;
          public KhachHangService(DataContext context){
             _context = context;
          }

        public void AddSKhachHang(KhachHang khachhang)
        {
              _context.KhachHangs.Add(khachhang);
             _context.SaveChanges();
        }

        public void DeleteKhachHangById(string id)
        {
              _context.KhachHangs.Remove(GetKhachHangById(id));
            _context.SaveChanges();
        }

        public void DeleteKhachHangById(int id)
        {
            throw new NotImplementedException();
        }

        public KhachHang GetKhachHangById(string id)
        {
         return _context.KhachHangs.FirstOrDefault(x => x.MaKH == id);
        }

       

        public List<KhachHang> getKhachHangs(){
            return _context.KhachHangs.ToList();
              
          }

        public List<LichSuKhachHang> getLichSuKhachHang(string kh_id)
        {
           var model = (from k in _context.KhachHangs 
                   join l in _context.LichSuTiemPhongs on k.MaKH equals l.MaKH
                   join v in _context.VacXins on l.MaVacXin equals v.MaVacXin
                   join p in _context.PhongBenhs on v.MaVacXin equals p.MaVacXin
                   join b in _context.Benhs on p.MaBenh equals b.MaBenh 
                   where k.MaKH == kh_id
                    select new LichSuKhachHang{
                       TenBenh = b.TenBenh,
                       MaVacXin = l.MaVacXin,
                       TenVacXin = v.TenVacXin,
                       SoMui =v.SoMui
                   }).ToList();


                   return model;
        }

        public List<KhachHang> searchKhachHangByName(string keyword)
        {
            keyword = keyword.Trim();
            Console.WriteLine(keyword);
            var ls = (from kh in _context.KhachHangs where kh.HoTenKH.Contains(keyword) select kh).ToList();
            return ls;
       
        }

        public void updateKhachHang(KhachHang khachhang)
        {
            
             var khachhangs = GetKhachHangById(khachhang.MaKH);
            khachhangs.MaKH = khachhang.MaKH;
            khachhangs.HoTenKH = khachhang.HoTenKH;
            khachhangs.SoDienThoai = khachhang.SoDienThoai;
            khachhangs.DiaChiKH = khachhang.DiaChiKH;
            khachhangs.NgaySinh = khachhang.NgaySinh;
             khachhangs.GioiTinh = khachhang.GioiTinh;
             _context.SaveChanges();
        }
        



    }
}

