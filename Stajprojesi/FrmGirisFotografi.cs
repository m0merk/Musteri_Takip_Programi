using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stajprojesi
{
    public partial class FrmGirisFotografi : Form
    {
        public FrmGirisFotografi()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void FrmGirisFotografi_Load(object sender, EventArgs e)
        {
            
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            if (sayac==5)
            {
                sayac = 0;
                FrmGiris frm = new FrmGiris();
                frm.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
