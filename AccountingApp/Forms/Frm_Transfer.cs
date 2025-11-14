using AccountingApp.Data;

namespace AccountingApp.Forms
{
  public partial class Frm_Transfer : Form
  {
    private string _accountId = string.Empty;

    public Frm_Transfer()
    {
      InitializeComponent();
    }
    public Frm_Transfer(string AccountId)
    {
      _accountId = AccountId;
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
      string t_DepositorId = txt_depositorId.Text;
      string t_receiverId = txt_ReceiverId.Text;
      string t_Amount = txt_Amount.Text;

      #region اعتبارسنجی
      if (string.IsNullOrEmpty(t_DepositorId) || string.IsNullOrEmpty(t_receiverId) || string.IsNullOrEmpty(t_Amount))
      {
        MessageBox.Show("لطفا مقادیر خواسته شده را وارد نمائید");
      }
      else if (decimal.TryParse(t_Amount, out decimal Amount) == false)
      {
        MessageBox.Show("لطفا مقدار عددی برای مبلغ وارد کنید");
      }
      else if (int.TryParse(t_DepositorId, out int DepositorId) == false)
      {
        MessageBox.Show("لطفا مقدار عددی برای شناسه حساب واریز کننده وارد کنید");
      }
      else if (int.TryParse(t_receiverId, out int ReceiverId) == false)
      {
        MessageBox.Show("لطفا مقدار عددی برای شناسه حساب دریافت کننده وارد کنید");
      }
      else if (Amount <= 0)
      {
        MessageBox.Show("مقدار مبلغ باید بیشتر از 0 باشد");
      }
      #endregion
      else
      {
        SqlDataContext context = new();
        var result = context.TransferMoney(DepositorId, ReceiverId, Amount);
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

    private void Frm_Transfer_Load(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(_accountId) is false)
      {
        txt_depositorId.Text = _accountId;
      }
    }
  }
}
