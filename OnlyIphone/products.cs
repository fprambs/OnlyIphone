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
    public partial class products : UserControl
    {
        private static products _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static products Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new products();
                return _instance;
            }
        }
        public products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProducts prd = new addProducts();
            prd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addType newtype = new addType();
            newtype.Show();
        }
    }
}
