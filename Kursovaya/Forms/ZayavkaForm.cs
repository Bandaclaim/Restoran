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
    public partial class ZayavkaForm : Form
    {
        LibContext db;
        public ZayavkaForm()
        {
            InitializeComponent();
            db = new LibContext();
            db.Zayavkas.Load();
            dataGridView1.DataSource = db.Zayavkas.Local.ToBindingList();

        }

        private void AddClick(object sender, EventArgs e)
        {
            ZayavkaEdit zayavkaEdit = new ZayavkaEdit();
            zayavkaEdit.button1.Text = "Добавить";
            Zayavka zayavka = new Zayavka();
            DialogResult result = zayavkaEdit.ShowDialog(this);
            SaveData(zayavkaEdit, result, zayavka, "добавлены");
        }

        private void SaveData(ZayavkaEdit zayavkaEdit, DialogResult result, Zayavka zayavka, string str)
        {

            if (result == DialogResult.OK)
            {
                try
                {
                    zayavka.Event = zayavkaEdit.comboBox2.Text;
                    zayavka.DataSostavlen = zayavkaEdit.dateTimePicker1.Value;
                    zayavka.DataEvent = zayavkaEdit.dateTimePicker2.Value;
                    zayavka.FIOClient = zayavkaEdit.comboBox1.Text;
                    zayavka.Telephone = zayavkaEdit.textBox4.Text;
                    zayavka.Count = int.Parse(zayavkaEdit.textBox2.Text);
                    zayavka.TimeHot = zayavkaEdit.textBox3.Text;
                    db.Zayavkas.Add(zayavka);
                    db.SaveChanges();

                    MessageBox.Show("Данные о заявке " + str);
                }
                catch (Exception exept)
                {
                    MessageBox.Show("Данные не были добавлены" + exept.Message);
                }
            }
        }

        private void EditClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return;
                Zayavka zayavka = db.Zayavkas.Find(id);
                List<Zayavka> zayavkas = db.Zayavkas.ToList();
                ZayavkaEdit zayavkaEdit = new ZayavkaEdit();
                List<string> client = new List<string>();
                foreach (Zayavka o in zayavkas)
                {
                    client.Add(o.FIOClient);
                }
                List<string> distinct = client.Distinct().ToList();
                zayavkaEdit.comboBox1.DataSource = distinct;

                zayavkaEdit.dateTimePicker1.Value = zayavka.DataSostavlen;
                zayavkaEdit.dateTimePicker2.Value = zayavka.DataEvent;
                zayavkaEdit.comboBox1.Text = zayavka.FIOClient.ToString();
                zayavkaEdit.textBox2.Text = zayavka.Count.ToString();
                zayavkaEdit.textBox3.Text = zayavka.TimeHot;

                DialogResult result = zayavkaEdit.ShowDialog(this);
                SaveData(zayavkaEdit, result, zayavka, "изменены");
            }
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = int.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return;

                Zayavka zayavka = db.Zayavkas.Find(id);
                db.Zayavkas.Remove(zayavka);
                db.SaveChanges();
                MessageBox.Show("Объект удалён");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SortClick(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.OrderBy(p => p.FIOClient).ToList();
            if (radioButton2.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.OrderBy(p => p.Telephone).ToList();
            if (radioButton3.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.OrderBy(p => p.DataSostavlen).ToList();
            if (radioButton4.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.OrderBy(p => p.DataEvent).ToList();
            if (radioButton5.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.OrderBy(p => p.Event).ToList();
            if (radioButton6.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.OrderBy(p => p.Count).ToList();
        }

        private void ResetClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = db.Zayavkas.Local.ToBindingList();
        }

        private void SearchClick(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.Where(p => p.FIOClient.Contains(textBox1.Text)).ToList();
            if (radioButton2.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.Where(p => p.Telephone.Contains(textBox1.Text)).ToList();
            if (radioButton3.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.Where(p => p.DataSostavlen.ToString().Contains(textBox1.Text)).ToList();
            if (radioButton4.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.Where(p => p.DataEvent.ToString().Contains(textBox1.Text)).ToList();
            if (radioButton5.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.Where(p => p.Event.Contains(textBox1.Text)).ToList();
            if (radioButton6.Checked == true) dataGridView1.DataSource = db.Zayavkas.Local.Where(p => p.Count.ToString().Contains(textBox1.Text)).ToList();
        }
    }
}
