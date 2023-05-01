using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Kursovaya.Model;
using System.Data.Entity;
using System.Windows.Forms;

namespace Kursovaya.Forms
{
    public partial class PersonalForm : Form
    {
        LibContext db;
        public PersonalForm()
        {
            InitializeComponent();
            db = new LibContext();
            db.Personals.Load();
            dataGridView1.DataSource = db.Personals.Local.ToBindingList();

        }

        private void AddClick(object sender, EventArgs e)
        {
            PersonalEdit personalEdit = new PersonalEdit();
            personalEdit.button1.Text = "Добавить";
            Personal personal = new Personal();
            DialogResult result = personalEdit.ShowDialog(this);
            SaveData(personalEdit, result, personal, "добавлены");
        }

        private void SaveData(PersonalEdit personalEdit, DialogResult result, Personal personal,string str)
        {
            if (result == DialogResult.OK)
            {
                try
                {
                    personal.FirstName = personalEdit.textBox2.Text;
                    personal.LastName = personalEdit.textBox3.Text;
                    personal.SecondName = personalEdit.textBox1.Text;
                    personal.DateOfBirth = personalEdit.dateTimePicker1.Value;
                    personal.Telephone = personalEdit.textBox4.Text;
                    personal.Doljnost = personalEdit.textBox5.Text;
                    if (str == "добавлены") db.Personals.Add(personal);
                    db.SaveChanges();

                    MessageBox.Show("Данные о персонале " + str);
                }
                catch (Exception exept)
                {
                    MessageBox.Show("Данные не " + str + ".\n" + exept.Message);
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
                Personal personal = db.Personals.Find(id);
                PersonalEdit personalEdit = new PersonalEdit();
                personalEdit.button1.Text = "Изменять";
                personalEdit.textBox2.Text = personal.FirstName;
                personalEdit.textBox1.Text = personal.SecondName;
                personalEdit.textBox3.Text = personal.LastName;
                personalEdit.textBox4.Text = personal.Telephone;
                personalEdit.textBox5.Text = personal.Doljnost;
                personalEdit.dateTimePicker1.Value= personal.DateOfBirth;

                DialogResult result = personalEdit.ShowDialog(this);
                SaveData(personalEdit, result, personal, "изменены");
            }    
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = int.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if(converted == false) return;

                Personal personal = db.Personals.Find(id);
                db.Personals.Remove(personal);
                db.SaveChanges();

                MessageBox.Show("Объект удалён");
            }    
        }
    }
}
