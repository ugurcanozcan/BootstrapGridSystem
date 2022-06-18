using BootstrapGridSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BootstrapGridSystem.Models
{
    public class Kullanici
    {
        SqlProcess process = new SqlProcess();
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }

        public void KayitOl()
        {
            process.SetExecuteNonQuery("insert into Kullanici (Ad, Soyad, TelefonNo, Email, KullaniciAdi, Sifre, Adres, Il, Ilce) values(@ad, @soyad, @telefon, @email, @kullaniciadi, @sifre, @adres, @il, @ilce)",
                new SqlParameter("@ad",Ad),
                new SqlParameter("@soyad",Soyad),
                new SqlParameter("@telefon",TelefonNo),
                new SqlParameter("@email",Email),
                new SqlParameter("@kullaniciadi",KullaniciAdi),
                new SqlParameter("@sifre",Sifre),
                new SqlParameter("@adres",Adres),
                new SqlParameter("@il",Il),
                new SqlParameter("@ilce",Ilce)
                );
        }

        public void GirisYap()
        {
        }

        public void KullanicilariGetir()
        {
            
        }
    }
}