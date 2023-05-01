using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursovaya.Model;
using System.Data.Entity;

namespace Kursovaya.Forms
{
    public partial class ZakazForm : Form
    {
        LibContext db;
        public ZakazForm()
        {
            InitializeComponent();
            db = new LibContext();
            db.Zakazs.Load();
            dataGridView1.DataSource = db.Zakazs.Local.ToBindingList();
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = int.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return;

                Zakaz zakazs = db.Zakazs.Find(id);
                db.Zakazs.Remove(zakazs);
                db.SaveChanges();
                MessageBox.Show("Объект удалён");

            }
        }
    }
}
