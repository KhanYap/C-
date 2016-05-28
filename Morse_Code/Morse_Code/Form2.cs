using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Code
{
    public partial class Legend : Form
    {
        public Legend()
        {
            InitializeComponent();
        }

        public string legend_text
        {
            get
            {
                return this.txt_legend.Text;
            }
            set
            {
                this.txt_legend.Text = value;
            }
        }
    }
}
