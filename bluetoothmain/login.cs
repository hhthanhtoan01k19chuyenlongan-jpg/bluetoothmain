using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bluetoothmain
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        string tkdung = "123";
        string mkdung = "1234";
        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (tk.Text == tkdung)
            {
                if (mk.Text == mkdung)
                {
                    bluetooth1 f2 = new bluetooth1();
                    this.Hide();
                    f2.Show();

                }
                else { MessageBox.Show("Sai tài khoản hoặc mật khẩu"); }


            }
            else { MessageBox.Show("Sai tài khoản hoặc mật khẩu"); }
        }
    }
}
