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
    public partial class DisciplinaryRecordForm : Form
    {

        public DisciplinaryRecordForm()
        {
            InitializeComponent();
            //Sets background and resizeable to false
            this.BackgroundImage = Properties.Resources.background;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
