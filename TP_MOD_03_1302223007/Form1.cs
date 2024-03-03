using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MOD_03_1302223007
{
    public partial class InputNamaApp : Form
    {
        public InputNamaApp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelGreeting.Text = "Halo " + inputNama.Text;
        }
    }
}
