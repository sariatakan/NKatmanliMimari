﻿using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LogicLayer
{
    public class LogicPersonel
    {
         public static List<EntityPersonel> LLPersonelListesi()
         {
            return DALPersonel.PersonelListesi();
         }
        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Ad.Length>=3)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLPersonelSil(int per)
        {
            if (per >= 1)
            {
                return DALPersonel.PersonelSil(per);
            }
            else
            { 
                return false; 
            }
        }
        public static bool LLPersonelGuncelle(EntityPersonel ent)
        {
            if(ent.Ad.Length>=3 && ent.Ad!="" && ent.Maas>=4500)
            {
                return DALPersonel.PersonelGuncelle(ent);
            }
            else { return false; }
        }

         
            
    } 
}
