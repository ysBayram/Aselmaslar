using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aselmaslar
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private void btnTanim_Click(object sender, EventArgs e)
        {
            FrmVeri fr = new FrmVeri(); this.Hide(); fr.ShowDialog(this);
        }

        private void btnPetrol_Click(object sender, EventArgs e)
        {
            FrmPetrol fr = new FrmPetrol(); this.Hide(); fr.ShowDialog(this);
        }

        private void btnNakliye_Click(object sender, EventArgs e)
        {

            FrmNakliye fr = new FrmNakliye(); this.Hide(); fr.ShowDialog(this);
        }

    }
}
