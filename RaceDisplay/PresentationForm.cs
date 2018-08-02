using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class PresentationForm : Form
    {
        public PresentationForm()
        {
            InitializeComponent();

            Screen[] screens = Screen.AllScreens;
            this.Location = screens[0].Bounds.Location;
            this.Size = new Size(screens[0].Bounds.Width, screens[0].Bounds.Height);
        }

        private void PresentationForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PresentationForm_SizeChanged(object sender, EventArgs e)
        {
            label1.Location = new Point((this.Width / 2) - (label1.Width / 2), (this.Height / 2) - (label1.Height / 2));
            currentContestant.Location = new Point((this.Width / 2) - (currentContestant.Width / 2), label1.Location.Y - currentContestant.Height);
            ageGroup.Location = new Point((this.Width / 2) - (currentContestant.Width / 2), label1.Location.Y + label1.Height);
        }
    }
}
