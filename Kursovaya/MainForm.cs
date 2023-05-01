using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursovaya.Forms;
using Kursovaya.Model;
using System.Data.Entity;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        LibContext db1;
        private void заявкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZayavkaEdit zayavkaEdit = new ZayavkaEdit();
            zayavkaEdit.button1.Text = "Добавить";
            db1 = new LibContext();
            db1.Zayavkas.Load();
            ZayavkaForm zayavkaForm = new ZayavkaForm();
            zayavkaForm.dataGridView1.DataSource = db1.Zayavkas.Local.ToBindingList();
            List<Zayavka> zayavkas = db1.Zayavkas.ToList();
            List<string> client = new List<string>();
            foreach (Zayavka zayavka in zayavkas)
            {
                client.Add(zayavka.FIOClient);
            }
            List<string> distinct = client.Distinct().ToList();
            zayavkaEdit.comboBox1.DataSource = distinct;

            DialogResult result = zayavkaEdit.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                try
                {
                    Zayavka zayavka = new Zayavka();
                    zayavka.Event = zayavkaEdit.comboBox2.Text;
                    zayavka.DataSostavlen = zayavkaEdit.dateTimePicker1.Value;
                    zayavka.DataEvent = zayavkaEdit.dateTimePicker2.Value;
                   
                    zayavka.FIOClient = zayavkaEdit.comboBox1.Text;
                    zayavka.Telephone = zayavkaEdit.textBox4.Text;
                    zayavka.Count = int.Parse(zayavkaEdit.textBox2.Text);
                    zayavka.TimeHot = zayavkaEdit.textBox3.Text;
                    db1.Zayavkas.Add(zayavka);
                    db1.SaveChanges();
                    MessageBox.Show("Данные о заявке добавлены");
                }
                catch (Exception exept)
                {
                    MessageBox.Show("Данные не были добавлены" + exept.Message);
                }
            }

        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalForm personalForm = new PersonalForm();
            personalForm.Show();
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZayavkaForm zayavkaForm = new ZayavkaForm();
            zayavkaForm.Show();
        }

        private void блюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishesForm dishesForm = new DishesForm();
            dishesForm.Show();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
        private void менюЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db1 = new LibContext();

            MenuZayavka menuZayavka = new MenuZayavka();
            menuZayavka.Show();
            db1 = new LibContext();
            List<Dishes> dishes = db1.Dishes.ToList();
            menuZayavka.comboBox1.DataSource = dishes;
            menuZayavka.comboBox1.ValueMember = "Id";
            menuZayavka.comboBox1.DisplayMember = "Name";

        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZakazForm zakazForm = new ZakazForm();
            zakazForm.Show();

        }

        private void чекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckEdit checkEdit = new CheckEdit();
            checkEdit.button1.Text = "Добавить";
            db1 = new LibContext();
            db1.Checks.Load();
            List<Personal> personals = db1.Personals.ToList();
            checkEdit.comboBox1.DataSource = personals;
            checkEdit.comboBox1.ValueMember = "Id";
            checkEdit.comboBox1.DisplayMember = "FIO";
            List<Zakaz> zakazs = db1.Zakazs.ToList();
            checkEdit.comboBox2.DataSource = zakazs;
            checkEdit.comboBox2.ValueMember = "Id";
            checkEdit.comboBox2.DisplayMember = "IdZakaz";
            DialogResult result = checkEdit.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                try
                {
                    Check check = new Check();
                    check.Stol = int.Parse(checkEdit.textBox1.Text);
                    check.StoimObsl = int.Parse(checkEdit.textBox2.Text);
                    check.Personal = (Personal)checkEdit.comboBox1.SelectedItem;
                    check.Zakaz = (Zakaz)checkEdit.comboBox2.SelectedItem;
                    var object1 = (Zakaz)checkEdit.comboBox2.SelectedItem;
                    check.NameBlud = object1.Names;
                    check.PriceBlud = object1.Prices;
                    var List = object1.Prices.Split('|').ToList();
                    int sum = 0;
                    for(int i = 0; i < List.Count-1; i++)
                    {
                        sum +=int.Parse(List[i].ToString());
                    }
                    check.ItogVsego = sum + int.Parse(checkEdit.textBox2.Text);
                    db1.Checks.Add(check);
                    db1.SaveChanges();

                    MessageBox.Show("Данные о заявке добавлены");
                }
                catch (Exception exept)
                {
                    MessageBox.Show("Данные не были добавлены" + exept.Message);
                }
            }
        }

        private void чекиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckForm checkForm = new CheckForm();
            checkForm.Show();
        }
    }
}
