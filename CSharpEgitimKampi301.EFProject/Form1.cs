using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTradelDbEntities db = new EgitimKampiEfTradelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {

            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.Name = txtBoxName.Text; 
            guide.Surname = txtBoxSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarı ile Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBoxId.Text);
            var removeValue=db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarı ile Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBoxId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.Name = txtBoxName.Text;
            updateValue.Surname = txtBoxSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarı ile Güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBoxId.Text);
            var values = db.Guide.Where(x=>x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }

       
       

    }
}
