using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace STOnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage="Mời nhập tên đăng nhập")]
        public string AdminName { set; get; }
        [Required(ErrorMessage = "Mời nhập mật khẩu")]
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}