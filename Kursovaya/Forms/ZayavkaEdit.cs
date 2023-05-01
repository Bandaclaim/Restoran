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

namespace Kursovaya.Forms
{
    public partial class ZayavkaEdit : Form
    {
        public ZayavkaEdit()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
             comboBox1.FindString(comboBox1.Text);
        }
    }
}
