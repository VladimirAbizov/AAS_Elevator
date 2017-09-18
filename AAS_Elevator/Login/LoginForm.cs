using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAS_Elevator
{
    public partial class LoginForm : Form
    {
        private readonly ElevatorContext _context;
        public LoginForm()
        {
            InitializeComponent();
            _context = new ElevatorContext();
            _context.Accounts.Load();
        }

        Account checkAccount;
        private bool CheckAccount()
        {
            checkAccount = _context.Accounts.Find(textBoxLogin.Text);

            if (checkAccount == null)
            {
                MessageBox.Show("Учетная запись с таким логином не найдена.");
                return false;
            }
            else
            {
                if (checkAccount.Password.ToString() != textBoxPassword.Text)
                {
                    MessageBox.Show("Неправильный пароль.");
                    return false;
                }

                return true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //if (CheckAccount() == false)
            //    return;
            //MainMenu.HideAndShowForm(this, new MainMenu(checkAccount.Category.Trim()));
            MainMenu.HideAndShowForm(this, new MainMenu("admin"));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        
    }
}
