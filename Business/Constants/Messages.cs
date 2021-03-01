using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
    public class Messages
    {
        public static string FirstNameNotEmpty = "İsim Alanı Boş Bırakılamaz";
        public static string LastNameNotEmpty = "Soyisim Alanı Boş Bırakılamaz";
        public static string EmailNotEmpty = "Email Alanı Boş Bırakılamaz";
        public static string TcNoNotEmpty = "TC Kimlik Numarası Alanı Boş Bırakılamaz";
        public static string DateOfBirthNotEmpty = "Doğum Tarihi Alanı Boş Bırakılamaz";
        public static string DateOfBirthLessThanDatetimeNow = "Doğum Tarihi Hatalı Girildi";
        public static string ErrorEmailAddressFormat = "Hatalı Email Adres Formatı";
        public static string TcNoLengthError = "TC Kimlik Numarası 11 hane olmalıdır";
        public static string UserValidateError = "Kullanıcı Doğrulaması Başarısız";
        public static string UserAlreadyExists = "Kullanıcı Daha Önce Kayıt Edilmiş";
    }
}
