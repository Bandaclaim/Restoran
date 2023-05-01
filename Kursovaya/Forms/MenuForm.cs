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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BludoForm bludoForm = new BludoForm();
            bludoForm.Show();
            bludoForm.Zakuski();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BludoForm bludoForm = new BludoForm();
            bludoForm.Show();
            bludoForm.ZakuskiInd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BludoForm bludoForm = new BludoForm();
            bludoForm.Show();
            bludoForm.Salat();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BludoForm bludoForm = new BludoForm();
            bludoForm.Show();
            bludoForm.Hotbl();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BludoForm bludoForm = new BludoForm();
            bludoForm.Show();
            bludoForm.Fish();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BludoForm bludoForm = new BludoForm();
            bludoForm.Show();
            bludoForm.Bird();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BludoForm bludoForm = new BludoForm();
            bludoForm.Show();
            bludoForm.Garnir();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BludoForm bludoForm = new BludoForm();
            bludoForm.Show();
            bludoForm.Des();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BludoForm bludoForm = new BludoForm();
            bludoForm.Show();
            bludoForm.Bar();
        }
    }
}
