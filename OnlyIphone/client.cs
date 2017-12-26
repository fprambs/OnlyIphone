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
    public partial class client : UserControl
    {
        private static client _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static client Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new client();
                return _instance;
            }
        }
        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {

        }
    }
}
