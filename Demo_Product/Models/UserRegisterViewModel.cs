﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage ="Lütfen bir isim girin.")]
        public string Name { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen bir soy isim girin.")]
        public string SurName { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen bir kullanıcı adı girin.")]
        public string UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen bir email girin.")]
        public string Email { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen bir şifre girin.")]
        public string Password { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen şifrenizi tekrar girin.")]
        [System.ComponentModel.DataAnnotations.Compare("Password",ErrorMessage ="Şifreyi doğru girin")]
        public string ConfirmPassword { get; set; }
    }
}
