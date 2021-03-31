using ItSays.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.Constants
{
    public static class Messages
    {
        public static string SuccessAdded = "Başarıyla eklendi.";
        public static string ErrorAdded = "Ekleme işlemi başarısız oldu.";
        public static string SuccessDeleted = "Başarıyla silindi.";
        public static string ErrorDeleted = "Silme işlemi başarısız oldu";
        public static string SuccessUpdated = "Başarıyla güncellendi.";
        public static string ErrorUpdated = "Güncelleme işlemi başarısız oldu.";

        public static string SuccessRegister = "Başarıyla Kayıt oldunuz.";
        public static string ErrorRegister = "Kayıt işlemi başarısız oldu.";
        public static string SuccessLogin = "Başarıyla giriş yaptınız.";
        public static string ErrorLogin = "Giriş işlemi başarısız oldu.";


        public static string AuthorizationDenied = "Bu işlemi yapabilmek için yetkiniz yok.";
        public static string SuccessFilter = "Filtre başarılı";
        
        public static string YouCannotUseThesePosts = "Bu tür kelimeleri kullanamazsın!";
        public static string AuthorRegistered = "Artık sizde bir yazarsınız.";
        public static string AuthorAlreadyExists = "Yazar var";
        public static string PasswordError = "Hatalı şifre";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string SuccessFullogin = "Giriş başarılı";
        public static string ArticleTitleAlreadyExists = "Girdiğiniz isim kullanılmaktadır lütfen başka bir isim giriniz.";

        public static string CategoryAdded = "Kategori başarıyla eklendi.";
        public static string CategoryDeleted = "Kategori başarıyla silindi.";
        public static string CategoryUpdated = "Kategoriler başarıyla eklendi.";
        public static string CategoryAlreadyExists = "Aynı isimde Kategori olamas.";
        public static string CategoryNameNotEmpty = "Kategori ismi boş geçilemez.";
        public static string DateError = "Tarih şimdiki zamandan büyük olamaz.";

        public static string Token = "İşlemler başarılı !";
    }
}
