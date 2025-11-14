using AccountingApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp.Forms
{
  public partial class Frm_Login : Form
  {
    public Frm_Login()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Frm_Main frm_Main = new Frm_Main();
      frm_Main.Show();

      Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string username = txt_Username.Text;
      string password = txt_Password.Text;
      #region اعتبارسنجی
      if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
      {
        MessageBox.Show("مقادیر لازم را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      #endregion
      else
      {
        SqlDataContext context = new();
        var result = context.Authenticate(username, password);
        if (result.Success)
        {
          MessageBox.Show("با موفقیت وارد شدید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
          Frm_CreateAccount frm_Create = new();
          frm_Create.Show();

          Hide();
        }
        else
        {
          MessageBox.Show(result.Message, "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
