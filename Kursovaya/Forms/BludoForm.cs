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
    public partial class BludoForm : Form
    {
        public BludoForm()
        {
            InitializeComponent();
        }
        LibContext db;
        public void Zakuski()
        {
            
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            dataGridView1.DataSource = db.Dishes.Local.Where(p=> p.Type.Contains("Закуски(общие)")).OrderBy(p =>p.Name).ToList();
            InitializeComponent();
            this.Text = "Закуски(общие)";
        }
        public void ZakuskiInd()
        {
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            dataGridView1.DataSource = db.Dishes.Local.Where(p => p.Type.Contains("Закуски(Индивидуальные)")).OrderBy(p => p.Name).ToList();
            InitializeComponent();
            this.Text = "Закуски(Индивидуальные)";
        }
        public void Salat()
        {
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            dataGridView1.DataSource = db.Dishes.Local.Where(p => p.Type.Contains("Салаты")).OrderBy(p => p.Name).ToList();
            InitializeComponent();
            this.Text = "Салаты";
        }
        public void Fish()
        {
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            dataGridView1.DataSource = db.Dishes.Local.Where(p => p.Type.Contains("Блюда из рыбы")).OrderBy(p => p.Name).ToList();
            InitializeComponent();
            this.Text = "Блюда из рыбы";
        }
        public void Bird()
        {
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            dataGridView1.DataSource = db.Dishes.Local.Where(p => p.Type.Contains("Блюда из мяса птицы")).OrderBy(p => p.Name).ToList();
            InitializeComponent();
            this.Text = "Блюда из мяса птицы";
        }
        public void Garnir()
        {
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            dataGridView1.DataSource = db.Dishes.Local.Where(p => p.Type.Contains("Гарниры")).OrderBy(p => p.Name).ToList();
            InitializeComponent();
            this.Text = "Гарниры";
        }
        public void Des()
        {
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            dataGridView1.DataSource = db.Dishes.Local.Where(p => p.Type.Contains("Десерты")).OrderBy(p => p.Name).ToList();
            InitializeComponent();
            this.Text = "Десерты";
        }
        public void Bar()
        {
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            dataGridView1.DataSource = db.Dishes.Local.Where(p => p.Type.Contains("Напиток")).OrderBy(p => p.Name).ToList();
            InitializeComponent();
            this.Text = "Напитки";
        }
        public void Hotbl ()
        {
            db = new LibContext();
            db.Dishes.Load();
            dataGridView1.DataSource = db.Dishes.Local.ToBindingList();
            dataGridView1.DataSource = db.Dishes.Local.Where(p => p.Type.Contains("Горячие блюда")).OrderBy(p => p.Name).ToList();
            InitializeComponent();
            this.Text = "Горячие блюда";
        }


    }
}
