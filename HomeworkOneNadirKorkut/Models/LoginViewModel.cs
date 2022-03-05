using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOneNadirKorkut.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Ad Alanı Boş Geçilemez!")]
        [Display(Name = "Ad")]
        [RegularExpression("^([a-zA-Z])+$", ErrorMessage = "Adınız sadece harflerden oluşmalıdır")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Boş Geçilemez!")]
        [Display(Name = "Soyad")]
        [RegularExpression("^([a-zA-Z])+$", ErrorMessage = "Soyadınız sadece harflerden oluşmalıdır")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Alanı Boş Geçilemez!")]
        [Display(Name = "E-Posta")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\.[A-Za-z0-9-]{2,}$", ErrorMessage = "Lütfen geçerli formatta bir email adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Boş Geçilemez!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.{0,8}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$", ErrorMessage = "Şifreniz en fazla 8 karakterden oluşmalıdır ve En az 1 Büyük Harf, 1 özel karakter,1 rakamdan oluşmalıdır.")]
        public string Password { get; set; }
    }
}
