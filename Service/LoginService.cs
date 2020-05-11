using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyTiemChung_MVC_DOTNET.Models;
using QuanLyTiemChung_MVC_DOTNET.ViewModel;


namespace QuanLyTiemChung_MVC_DOTNET.Service
{
    public interface ILoginService
    {

        public bool checkLogin(User user);
        
    }

    public class LoginService : ILoginService

    {
        private DataContext _context;
        public LoginService(DataContext context){
             _context = context;
        }
        public bool checkLogin(User user)
        {
           bool check = false;
          var ls = (from u in _context.Users where u.username == u.password select u).ToList().Count();
          if (ls > 0) check = true;

          return check;
        }
    }




}