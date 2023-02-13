using System;
using MedWalletAPI.Models;

namespace MedWallet.DataModels.Interfaces
{
	public interface IUserAccountDataSource
	{
		string Description { get; set; }

		List<UserAccount> GetAllAccounts();

		UserAccount GetAccount(string userName);

        UserAccount GetAccount(int id);

        UserAccount UpdateAccount(UserAccount acct);

        UserAccount AddAccount(UserAccount acct);

        bool DeleteAccount(int Id);
    }
}

