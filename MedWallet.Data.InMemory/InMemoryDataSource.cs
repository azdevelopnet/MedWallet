using System.Collections.Generic;
using MedWallet.DataModels.Interfaces;
using MedWalletAPI.Models;

namespace MedWallet.Data.InMemory;
public class InMemoryDataSource : IUserAccountDataSource
{
    private List<UserAccount> _accounts;

    public string Description { get; set; } = "InMemoryDataSource";

    public InMemoryDataSource()
    {
        _accounts = new List<UserAccount>();
        InitDummyData();
    }

    public UserAccount AddAccount(UserAccount acct)
    {
        _accounts.Add(acct);
        return acct;
    }

    public bool DeleteAccount(int Id)
    {
        var acct = _accounts.FirstOrDefault(x => x.Id == Id);
        if (acct != null)
        {
            _accounts.Remove(acct);
            return true;
        }
        else
        {
            return false;
        }
    }

    public UserAccount GetAccount(string userName)
    {
        return _accounts.FirstOrDefault(x => x.UserName == userName);
    }

    public UserAccount GetAccount(int id)
    {
        return _accounts.FirstOrDefault(x => x.Id == id);
    }

    public List<UserAccount> GetAllAccounts()
    {
        return _accounts;
    }

    public UserAccount UpdateAccount(UserAccount acct)
    {
        var obj = _accounts.FirstOrDefault(x => x.Id == acct.Id);
        if (obj != null)
        {
            foreach(var prop in typeof(UserAccount).GetProperties())
            {
                var objValue = prop.GetValue(acct);
                prop.SetValue(obj, objValue);
            }
            return obj;
        }
        else
        {
            return obj;
        }
    }

    private void InitDummyData()
    {
        _accounts.Add(new UserAccount()
        {
            FirstName = "Jack",
            LastName = "Sparrow",
            UserName = "jsparrow@gmail.com",
            DOB = DateTime.Now.AddYears(-30),
            Id = 1,
        });
        _accounts.Add(new UserAccount()
        {
            FirstName = "Sam",
            LastName = "Houston",
            UserName = "shouston@gmail.com",
            DOB = DateTime.Now.AddYears(-45),
            Id = 2,
        });
        _accounts.Add(new UserAccount()
        {
            FirstName = "Peter",
            LastName = "Parker",
            UserName = "pparker@gmail.com",
            DOB = DateTime.Now.AddYears(-20),
            Id = 3,
        });
        _accounts.Add(new UserAccount()
        {
            FirstName = "Riley",
            LastName = "Brown",
            UserName = "rbrown@gmail.com",
            DOB = DateTime.Now.AddYears(-10),
            Id = 4,
        });
    }
}

