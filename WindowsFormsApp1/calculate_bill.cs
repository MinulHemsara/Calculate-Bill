using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class calculate_bill : Form
    {
        public calculate_bill()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double unit,eu,ec, tot;
            unit =Convert.ToDouble(txt_unit.Text);
            if(cmb_type.SelectedIndex == 0)
            {
                if (unit <= 100)
                {
                    tot = 500 + 200;
                    txt_tot.Text = tot.ToString();
                }
                else
                {
                    eu = unit - 100;
                    ec = eu * 20;
                    tot = ec + 700; 
                    txt_tot.Text = tot.ToString();
                }
            }
            else if(cmb_type.SelectedIndex == 1)
            {

            }
        }
    }
}
