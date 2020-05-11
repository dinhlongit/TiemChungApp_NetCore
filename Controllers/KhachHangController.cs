using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyTiemChung_MVC_DOTNET.Models;
using QuanLyTiemChung_MVC_DOTNET.Service;
using QuanLyTiemChung_MVC_DOTNET.ViewModel;


namespace QuanLyTiemChung_MVC_DOTNET.Controllers
{
    public class KhachHangController : Controller
    {
        private IKhachHangService _khachHangService;
        
        public KhachHangController(IKhachHangService khachHangService){
            this._khachHangService = khachHangService;

        }

    
      

        public IActionResult Index()
        {
            
            ViewBag.khachHangs = _khachHangService.getKhachHangs();
            return View();
        }

        
        public IActionResult editkhachhang(string id)
        {
            var khachhang = _khachHangService.GetKhachHangById(id);
            ViewBag.khachhang = khachhang;
            
           
            return View();
        }

          public IActionResult updatekhachhang(KhachHang khach)
        {
            _khachHangService.updateKhachHang(khach);
            
            ViewBag.khachHangs = _khachHangService.getKhachHangs();
            
           
            return View("index");
        }

        public IActionResult searchkhachhang(string keyword){
         Console.WriteLine(keyword);
       //  ViewBag.khachhang =  _khachHangService.searchKhachHangByName(keyword);
        ViewBag.khachHangs = _khachHangService.searchKhachHangByName(keyword);
           return View("index");
        }

      
       

         public IActionResult delete(string id)
        {
            
            _khachHangService.DeleteKhachHangById(id);
            return View("index");
        }

        public IActionResult lichsukhachhang(string id){
           var lskh = _khachHangService.getLichSuKhachHang(id);
           ViewBag.lskh = lskh;
            return View();
        }
    

  public IActionResult addkhachhang(){
            return View();
        }
public IActionResult storekhachhang(KhachHang khachhang){
     _khachHangService.AddSKhachHang(khachhang);
       ViewBag.khachHangs = _khachHangService.getKhachHangs();
     return View("index");
}
    }
}