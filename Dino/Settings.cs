using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Dino.Classes;
namespace Dino
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Menu form2 = new Menu();
            form2.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Game form1 = new Game();
            form1.Chek1 = this.checkBox1.Checked;
            form1.Chek2 = this.checkBox2.Checked;
            form1.ShowDialog();
        }

    }
}


