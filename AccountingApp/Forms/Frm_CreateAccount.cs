using AccountingApp.Data;

namespace AccountingApp.Forms
{
  public partial class Frm_CreateAccount : Form
  {
    public Frm_CreateAccount()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string personName = txt_PersonName.Text;
      string balance = txt_Balance.Text;
      #region اعتبارسنجی
      if (string.IsNullOrEmpty(personName) || string.IsNullOrEmpty(balance))
      {
        MessageBox.Show("لطفا مقادیر خواسته شده را وارد کنید");
      }
      else if (decimal.TryParse(balance, out decimal d_balance) == false)
      {
        MessageBox.Show("لطفا مقدار معتبری در فیلد موجودی وارد کنید");
      }
      #endregion
      else
      {
        SqlDataContext context = new();
        var result = context.AddAccount(personName, d_balance);
        if (result.Success == true)
        {
          MessageBox.Show("عملیات با موفقیت انجام شد");
          new Frm_Main().Show();
          Hide();
        }

        else
          MessageBox.Show(result.Message);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Frm_Main frm_Main = new();
      frm_Main.Show();

      Hide();
    }
  }
}
