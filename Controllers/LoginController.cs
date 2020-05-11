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
    public class LoginController : Controller
    {

        private ILoginService _loginService;
        public LoginController(ILoginService loginService){
           _loginService = loginService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult checklogin(User user){
            
            if (_loginService.checkLogin(user) == true){
               return RedirectToAction("Index","KhachHang");  
            }else{
                return RedirectToAction("Index","Login");  
            }
            return View("index");
        }
    }
}

