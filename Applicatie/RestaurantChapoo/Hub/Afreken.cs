using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub
{
    public partial class Afreken : Form
    {
        public Afreken()
        {
            InitializeComponent();
        }

        private static Afreken _uniqueAfreken;
        public static Afreken GetAfrekenScreen()
        {
            if (_uniqueAfreken == null)
            {
                _uniqueAfreken = new Afreken();
            }
            return _uniqueAfreken;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hub hub = new Hub();
            hub.Show();
            this.Hide();
        }


    }
}
