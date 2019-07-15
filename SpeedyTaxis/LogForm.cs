using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedyTaxis
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();

            //Setting background color and resizeable to false
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackgroundImage = Properties.Resources.background;
        }
    }
}
