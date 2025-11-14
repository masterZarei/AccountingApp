using AccountingApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccountingApp.Data
{
    public class SqlDataContext
  {
        private readonly Result _result;
    private readonly SqlConnection _connection;
    private readonly SqlCommand _command;
    private const string connectionString = "Server=.;Database=AccountingAppDb;Trusted_Connection=True;TrustServerCertificate=true;";
    public SqlDataContext()
    {
      _result = new Result();
      _connection = new SqlConnection(connectionString);
      _command = new SqlCommand()
      {
        Connection = _connection
      };
    }
    private void Connection()
    {
      _connection.ConnectionString = connectionString;
    }
    public Result AddAccount(string personName, decimal Balance)
    {
      int result = -1;
      _command.CommandText = $"INSERT INTO tbl_Accounts VALUES ('{personName}',{Balance})";
      using (_connection)
      {
        Connection();
        _connection.Open();
        result = _command.ExecuteNonQuery();
        _connection.Close();
      }
      if (result > 0)
      {
        _result.Success = true;
        return _result;
      }
      else
      {
        _result.Success = false;
        _result.Message = "عملیات با خطا مواجه شد";
        return _result;
      }
    }
    public Result IncreaseBalance(int accountId, decimal amount)
    {

      #region Validation
      if (amount <= 0)
      {
        _result.Success = false;
        _result.Message = "مبلغ باید بیشتر از صفر باشد";
        return _result;
      }
      //Check if account Exists

      if (CheckIfAccountExists(accountId) == false)
      {
        _result.Success = false;
        _result.Message = "حسابی با این شناسه موجود نمی باشد";
        return _result;
      }
      #endregion
      int result = -1;
      _command.CommandText = $"UPDATE tbl_Accounts SET Balance=Balance+{amount} WHERE Id={accountId}";
      using (_connection)
      {
        Connection();
        _connection.Open();
        result = _command.ExecuteNonQuery();
        _connection.Close();
      }
      if (result > 0)
      {
        _result.Success = true;
        return _result;
      }
      else
      {
        _result.Success = false;
        _result.Message = "عملیات با خطا مواجه شد";
        return _result;
      }
    }
    public Result DecreaseBalance(int accountId, decimal amount)
    {

      #region Validation
      if (amount <= 0)
      {
        _result.Success = false;
        _result.Message = "مبلغ باید بیشتر از صفر باشد";
        return _result;
      }
      //Check if account Exists

      if (CheckIfAccountExists(accountId) == false)
      {
        _result.Success = false;
        _result.Message = "حسابی با این شناسه موجود نمی باشد";
        return _result;
      }
      //Check if balance is larger or equal to amount
      if (CheckIfEnoughBalance(accountId, amount) == false)
      {
        _result.Success = false;
        _result.Message = "موجودی حساب کمتر از مبلغ وارد شده می باشد";
        return _result;
      }
      #endregion
      int result = -1;
      _command.CommandText = $"UPDATE tbl_Accounts SET Balance=Balance-{amount} WHERE Id={accountId}";
      using (_connection)
      {
        Connection();
        _connection.Open();
        result = _command.ExecuteNonQuery();
        _connection.Close();
      }
      if (result > 0)
      {
        _result.Success = true;
        return _result;
      }
      else
      {
        _result.Success = false;
        _result.Message = "عملیات با خطا مواجه شد";
        return _result;
      }
    }
    public Result TransferMoney(int depositortId, int receiverId, decimal amount)
    {
      #region Validation
      if (amount <= 0)
      {
        _result.Success = false;
        _result.Message = "مبلغ باید بیشتر از صفر باشد";
        return _result;
      }
      //Check if account Exists
      if (CheckIfAccountExists(depositortId) == false || CheckIfAccountExists(receiverId) == false)
      {
        _result.Success = false;
        _result.Message = "حسابی با این شناسه موجود نمی باشد";
        return _result;
      }
      //Check if balance is larger or equal to amount
      if (CheckIfEnoughBalance(depositortId, amount) == false)
      {
        _result.Success = false;
        _result.Message = "موجودی حساب کمتر از مبلغ وارد شده می باشد";
        return _result;
      }
      #endregion
      int result = -1;
      _command.CommandText = $"UPDATE tbl_Accounts SET Balance=Balance-{amount} WHERE Id={depositortId}; UPDATE tbl_Accounts SET Balance=Balance+{amount} WHERE Id={receiverId};";
      using (_connection)
      {
        Connection();
        _connection.Open();
        result = _command.ExecuteNonQuery();
        _connection.Close();
      }
      if (result > 0)
      {
        _result.Success = true;
        return _result;
      }
      else
      {
        _result.Success = false;
        _result.Message = "عملیات با خطا مواجه شد";
        return _result;
      }

    }
    public Result Authenticate(string username, string password)
    {
      string result = string.Empty;
      _command.CommandText = $"SELECT Username FROM tbl_AdminUsers WHERE Username='{username}' and Password='{password}'";
      using (_connection)
      {
        Connection();
        _connection.Open();
        result = _command.ExecuteScalar()?.ToString();
        _connection.Close();
      }

      if (string.IsNullOrEmpty(result) == false)
      {
        _result.Success = true;
        return _result;
      }
      else
      {
        _result.Success = false;
        _result.Message = "ورود نامعتبر";
        return _result;
      }
    }

    public DataTable GetAllUsers()
    {
      DataTable dt = new DataTable();
      _command.CommandText = $"SELECT * FROM tbl_Accounts";
      using (_connection)
      {
        Connection();
        _connection.Open();
        SqlDataAdapter sqlDataAdapter = new(_command);
        sqlDataAdapter.Fill(dt);
        _connection.Close();
      }
      return dt;
    }



    #region Validation
    public bool CheckIfAccountExists(int accountId)
    {
      string result = string.Empty;
      _command.CommandText = $"SELECT * FROM tbl_Accounts WHERE Id={accountId}";
      using (_connection)
      {
        Connection();
        _connection.Open();
        result = _command.ExecuteScalar()?.ToString();
        _connection.Close();
      }
      if (string.IsNullOrEmpty(result) == false)
        return true;
      return false;
    }

    public bool CheckIfEnoughBalance(int accountId, decimal leastAmount)
    {
      string result = string.Empty;
      _command.CommandText = $"SELECT Balance FROM tbl_Accounts WHERE Id={accountId}";
      using (_connection)
      {
        Connection();
        _connection.Open();
        result = _command.ExecuteScalar()?.ToString();
        _connection.Close();
      }
      if (decimal.TryParse(result, out decimal amount))
      {
        if (amount >= leastAmount)
          return true;
      }
      return false;
    }
    #endregion
  }
}
