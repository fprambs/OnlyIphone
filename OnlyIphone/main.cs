using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyIphone
{
    public partial class main : UserControl
    {
        private static main _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static main Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new main();
                return _instance;
            }
        }

        public main()
        {
 
              InitializeComponent();
              timer1.Enabled = true;

        }

        private void main_Load(object sender, EventArgs e)
        {
            DateTime dateValue = DateTime.Now;
            dayNumerLabel.Text = dateValue.ToString("dd");
            dayNameLabel.Text = Utils.FirstLetterToUpeer(dateValue.ToString("dddd"));
            monthLabel.Text = Utils.FirstLetterToUpeer(dateValue.ToString("MMMM"));
            yearLabel.Text = dateValue.ToString("yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("T");
        }
    }
}
