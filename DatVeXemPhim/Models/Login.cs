using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatVeXemPhim.Models
{
    public class Login
    {
        [Key]
        [Display(Name ="Tên đăng nhập")]
        [Required(ErrorMessage ="Bạn cần nhập tài khoản")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Bạn cần nhập mật khẩu")]
        [DataType(DataType.Password)]
        [Display(Name ="Mật khẩu")]
        public string Password { get; set; }
    }
}