using MedWallet.DataModels.Interfaces;
using MedWalletAPI.Models;

namespace MedWallet.Data.NOSql;
public class NoSqlDataSource : IUserAccountDataSource
{
    public string Description { get; set; } = "NoSqlDataSource";

    public UserAccount AddAccount(UserAccount acct)
    {
        throw new NotImplementedException();
    }

    public bool DeleteAccount(int Id)
    {
        throw new NotImplementedException();
    }

    public UserAccount GetAccount(string userName)
    {
        throw new NotImplementedException();
    }

    public UserAccount GetAccount(int id)
    {
        throw new NotImplementedException();
    }

    public List<UserAccount> GetAllAccounts()
    {
        throw new NotImplementedException();
    }

    public UserAccount UpdateAccount(UserAccount acct)
    {
        throw new NotImplementedException();
    }
}

