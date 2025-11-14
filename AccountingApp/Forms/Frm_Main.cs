using AccountingApp.Data;

namespace AccountingApp.Forms
{
  public partial class Frm_Main : Form
  {
    public Frm_Main()
    {
      InitializeComponent();
    }

    private readonly SqlDataContext context = new();

    private void افزایشموجودیToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Frm_Increase frm_inc = new(GetAccountId());
      frm_inc.Show();


      Hide();
    }

    private void کاهشموجودیToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Frm_Decrease frm_dec = new(GetAccountId());
      frm_dec.Show();

      Hide();
    }

    private void ایجادحسابجدیدToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Frm_Login frm_login = new();
      frm_login.Show();

      Hide();
    }

    private void انتقالوجهToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Frm_Transfer frm_Transfer = new(GetAccountId());
      frm_Transfer.Show();

      Hide();
    }

    private void Frm_Main_Load(object sender, EventArgs e)
    {
      LoadData();
      dgv.Columns[0].HeaderText = "شناسه";
      dgv.Columns[1].HeaderText = "نام کاربر";
      dgv.Columns[2].HeaderText = "موجودی حساب";
      dgv.Columns[2].Width = 200;
    }
    private void LoadData()
    {
      dgv.DataSource = context.GetAllUsers();
    }
    private string GetAccountId()
    {
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      var accountId = dgv.Rows[rowIndex].Cells[0].Value.ToString();
      if (string.IsNullOrEmpty(accountId))
      {
        return null;
      }
      return accountId;
    }

    private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
  }
}
