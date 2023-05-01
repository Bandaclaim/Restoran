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
    }
}
