using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Kursovaya.Model;

namespace Kursovaya.Forms
{
    public partial class MenuZayavka : Form
    {
        LibContext db;
        public MenuZayavka()
        {
            InitializeComponent();
            db = new LibContext();
            db.Zakazs.Load();
        }
        string NBLUD;
        string Prices;
        int sum;
        public void button1_Click(object sender, EventArgs e)
        {

            db = new LibContext();
            List<Dishes> dishes = db.Dishes.ToList();
            int id = 0;
            id = int.Parse(comboBox1.SelectedValue.ToString());
            for (int i = 0; i < dishes.Count; i++)
            {
                if (id == dishes[i].Id)
                {
                    id = i;
                    break;
                }
            }
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = dishes[id].Name.ToString();
            dataGridView1.Rows[index].Cells[1].Value = dishes[id].Price.ToString();
            sum += int.Parse(dishes[id].Price.ToString());
            label2.Text = sum.ToString();
            NBLUD += dishes[id].Name.ToString() + "|";
            Prices += dishes[id].Price.ToString() + "|";
            Zakaz zakaz = new Zakaz();
            if (checkBox1.Checked)
            {
                SaveData(zakaz,NBLUD,Prices);
            }
        }

        private void SaveData( Zakaz zakaz,string NBLUD,string Prices)
        {
                try
                {
                    zakaz.Names=NBLUD;
                    zakaz.Prices = Prices;
                    zakaz.Itogo = int.Parse(label2.Text);
                    db.Zakazs.Add(zakaz);
                    db.SaveChanges();

                    MessageBox.Show("Заказ добавлен");
                }
                catch (Exception exept)
                {
                    MessageBox.Show("Заказ не добавлен " + ".\n" + exept.Message);
                }
        }


        public void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckEdit form3 = new CheckEdit();
            form3.Show();
        }
    }
}
