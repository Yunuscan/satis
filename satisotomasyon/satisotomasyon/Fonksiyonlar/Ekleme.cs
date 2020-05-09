using satisotomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisotomasyon.Fonksiyonlar
{
    class Ekleme
    {
        db_entity db = new db_entity();
        public void anakategoriekleme(string ad)
        {
            Kategori yeni = new Kategori()
            {
                Pid = 0,
                Kategori_Adi = ad
            };
            db.Kategori.Add(yeni);
            db.SaveChanges();

        }
        public void altkategoriekleme(int anaid, string ad)
        {
            Kategori yeni = new Kategori()
            {
                Pid = anaid,
                Kategori_Adi = ad
            };
            db.Kategori.Add(yeni);
            db.SaveChanges();

        }
    }
}
