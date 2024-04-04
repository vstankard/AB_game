using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AB_game
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnMaker_Click(object sender, EventArgs e)
        {
            Form1 codeMaker = new Form1();
            codeMaker.Show();
        }

        private void btnBreaker_Click(object sender, EventArgs e)
        {
            CodeBreaker codeBreaker = new CodeBreaker();
            codeBreaker.Show();
        }
    }
}
