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
  public partial class Frm_Decrease : Form
  {
    private string _accountId = string.Empty;

    public Frm_Decrease()
    {
      InitializeComponent();
    }
    public Frm_Decrease(string AccountId)
    {
      InitializeComponent();
      _accountId = AccountId;
    }
    private void button2_Click(object sender, EventArgs e)
    {
      Frm_Main frm_Main = new Frm_Main();
      frm_Main.Show();
      Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string t_AccountId = txt_AccountId.Text;
      string t_Amount = txt_Amount.Text;

      #region اعتبارسنجی
      if (string.IsNullOrEmpty(t_AccountId) || string.IsNullOrEmpty(t_Amount))
      {
        MessageBox.Show("لطفا مقادیر خواسته شده را وارد نمائید");
      }
      else if (decimal.TryParse(t_Amount, out decimal Amount) == false)
      {
        MessageBox.Show("لطفا مقدار عددی برای مبلغ وارد کنید");
      }
      else if (int.TryParse(t_AccountId, out int AccountId) == false)
      {
        MessageBox.Show("لطفا مقدار عددی برای شناسه حساب وارد کنید");
      }
      else if (Amount <= 0)
      {
        MessageBox.Show("مقدار مبلغ باید بیشتر از 0 باشد");
      }
      #endregion
      else
      {
        SqlDataContext context = new();
        var result = context.DecreaseBalance(AccountId, Amount);
        if (result.Success == true)
        {
          MessageBox.Show("عملیات با موفقیت انجام شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
          Hide();
          new Frm_Main().Show();
        }
        else
          MessageBox.Show(result.Message, "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);

        
      }
    }

    private void Frm_Decrease_Load(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(_accountId) is false)
      {
        txt_AccountId.Text = _accountId;
      }
    }
  }
}
