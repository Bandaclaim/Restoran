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
using Word = Microsoft.Office.Interop.Word;
using Kursovaya.Paper_work;

namespace Kursovaya.Forms
{
    public partial class CheckForm : Form
    {
        LibContext db;
        public CheckForm()
        {
            InitializeComponent();
            db = new LibContext();
            db.Checks.Load();
            dataGridView1.DataSource = db.Checks.Local.ToBindingList();
        }
        Word._Application oWord = new Word.Application();
        private void button1_Click(object sender, EventArgs e)
        {
            List<Check> checks = db.Checks.ToList();
            MessageBox.Show(checks[0].Zakaz.Prices);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                List<Check> checks = db.Checks.ToList();
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = int.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return;
                var changer = new WordReplacer("test.docx");
                var list1 = checks[id - 1].Zakaz.Names.ToString().Split('|').ToList();
                string s = null;
                foreach (string item in list1)
                {
                    //s = s + item.Substring(0, item.Count()) + "\r";
                    s += item.Substring(0, item.Count()) + "^l";
                }
                var list2 = checks[id - 1].Zakaz.Prices.ToString().Split('|').ToList();
                string s2 = null;
                foreach (string item in list2)
                {
                    s2 += item.Substring(0, item.Count()) + "^l";
                }
                var items = new Dictionary<string, string>
            {
                { "<ORDERID>", (checks[id-1].Zakaz.ToString()) },
                { "<DISHES>", (s) },
                { "<PRICES>", (s2) },
                { "<TOTAL>", (checks[id-1].Zakaz.Itogo).ToString() },
                { "<PERSONEL>", (checks[id-1].Personal.FIO.ToString()) },
                { "<SERVICECOST>", (checks[id-1].StoimObsl.ToString()) },
                { "<PLACENUM>", (checks[id-1].Stol.ToString()) }
            };

                changer.Process(items);
        }

        private void SortClick(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) dataGridView1.DataSource = db.Checks.Local.OrderBy(p => p.ZakazId).ToList();
            if (radioButton2.Checked == true) dataGridView1.DataSource = db.Checks.Local.OrderBy(p => p.Personal).ToList();
            if (radioButton3.Checked == true) dataGridView1.DataSource = db.Checks.Local.OrderBy(p => p.NameBlud).ToList();
            if (radioButton4.Checked == true) dataGridView1.DataSource = db.Checks.Local.OrderBy(p => p.PriceBlud).ToList();
            if (radioButton5.Checked == true) dataGridView1.DataSource = db.Checks.Local.OrderBy(p => p.StoimObsl).ToList();
            if (radioButton6.Checked == true) dataGridView1.DataSource = db.Checks.Local.OrderBy(p => p.Stol).ToList();
            if (radioButton7.Checked == true) dataGridView1.DataSource = db.Checks.Local.OrderBy(p => p.Zakaz.Itogo.ToString()).ToList();
        }

        private void ResetClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = db.Checks.Local.ToBindingList();
        }

        private void SearchClick(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) dataGridView1.DataSource = db.Checks.Local.Where(p => p.ZakazId.ToString().Contains(textBox1.Text)).ToList();
            if (radioButton2.Checked == true) dataGridView1.DataSource = db.Checks.Local.Where(p => p.Personal.ToString().Contains(textBox1.Text)).ToList();
            if (radioButton3.Checked == true) dataGridView1.DataSource = db.Checks.Local.Where(p => p.NameBlud.ToString().Contains(textBox1.Text)).ToList();
            if (radioButton4.Checked == true) dataGridView1.DataSource = db.Checks.Local.Where(p => p.PriceBlud.ToString().Contains(textBox1.Text)).ToList();
            if (radioButton5.Checked == true) dataGridView1.DataSource = db.Checks.Local.Where(p => p.StoimObsl.ToString().Contains(textBox1.Text)).ToList();
            if (radioButton6.Checked == true) dataGridView1.DataSource = db.Checks.Local.Where(p => p.Stol.ToString().Contains(textBox1.Text)).ToList();
            if (radioButton7.Checked == true) dataGridView1.DataSource = db.Checks.Local.Where(p => p.Zakaz.Itogo.ToString().Contains(textBox1.Text)).ToList();
        }
    }
}
