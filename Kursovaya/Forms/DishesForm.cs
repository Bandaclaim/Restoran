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
    public partial class DishesForm : Form
    {
        LibContext db;
        public DishesForm()
        {
            InitializeComponent();
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = int.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return;

                Dishes dishes = db.Dishes.Find(id);
                db.Dishes.Remove(dishes);
                db.SaveChanges();
                MessageBox.Show("Объект удалён");
            }
        }

        private void AddClick(object sender, EventArgs e)
        {
            DishesEdit dishesEdit = new DishesEdit();
            dishesEdit.button1.Text = "Добавить";
            Dishes dishes = new Dishes();
            DialogResult result = dishesEdit.ShowDialog(this);
            SaveData(dishesEdit, result, dishes, "добавлены");
        }

        private void SaveData(DishesEdit dishesEdit, DialogResult result, Dishes dishes, string str)
        {
            if (result == DialogResult.OK)
            {
                try
                {
                    dishes.Name = dishesEdit.textBox1.Text;
                    dishes.Price = int.Parse(dishesEdit.textBox2.Text);
                    dishes.Type = dishesEdit.comboBox1.Text;
                    dishes.Ves = int.Parse(dishesEdit.textBox3.Text);
                    if (str == "добавлены") db.Dishes.Add(dishes);
                    db.SaveChanges();

                    MessageBox.Show("Данные о блюде " + str);
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
                Dishes dishes = db.Dishes.Find(id);
                DishesEdit dishesEdit = new DishesEdit();
                dishesEdit.button1.Text = "Изменять";
                dishesEdit.textBox1.Text = dishes.Name;
                dishesEdit.textBox2.Text = dishes.Price.ToString();
                dishesEdit.textBox3.Text = dishes.Ves.ToString();

                DialogResult result = dishesEdit.ShowDialog(this);
                SaveData(dishesEdit, result, dishes, "изменены");
            }
        }


    }
}
