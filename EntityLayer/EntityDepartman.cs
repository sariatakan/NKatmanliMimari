using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityDepartman
    {
        private int id;
        private int ad;
        private string aciklama;

        public int Id { get => id; set => id = value; }
        public int Ad { get => ad; set => ad = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
    }
}
