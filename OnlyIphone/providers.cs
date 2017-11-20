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
    public partial class providers : UserControl
    {
        private static providers _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static providers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new providers();
                return _instance;
            }
        }
        public providers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProviders newProvider = new addProviders();
            newProvider.Show();
        }
    }
}
