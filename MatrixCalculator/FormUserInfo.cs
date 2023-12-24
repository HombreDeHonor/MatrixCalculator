using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class FormUserInfo : Form
    {
        public FormUserInfo()
        {
            InitializeComponent();
        }

        public FormUserInfo(User user)
        {
            InitializeComponent();

            textBoxName.Enabled = true;
            textBoxID.Enabled = true;
            textBoxDate.Enabled = true;

            textBoxName.Text = user.Name;
            textBoxID.Text = user.GetUserID().ToString();
            textBoxDate.Text = user.CreationDate.ToString();
        }

    }
}
