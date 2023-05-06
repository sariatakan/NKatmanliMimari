using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataAccessLayer;



namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnListele_Click(object sender, EventArgs e)
        {

            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir = TxtSehir.Text;
            ent.Gorev = TxtGorev.Text;
            ent.Maas = short.Parse(TxtMaas.Text);
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt16(textbox1.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad= TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir= TxtSehir.Text;
            ent.Gorev = TxtGorev.Text;
            ent.Maas = short.Parse(TxtMaas.Text);
            LogicPersonel.LLPersonelGuncelle(ent);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbPersonelDataSet.TBLBİLGİ' table. You can move, or remove it, as needed.
            this.tBLBİLGİTableAdapter.Fill(this.dbPersonelDataSet.TBLBİLGİ);


        }
    }
}
