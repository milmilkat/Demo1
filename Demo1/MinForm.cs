using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class MinForm : Form
    {
        Logic LogicObj = new Logic();

        public MinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicObj.LoadGun();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogicObj.SpinGun();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer SP = new SoundPlayer();
            SP.Play();
        }
    }
}
