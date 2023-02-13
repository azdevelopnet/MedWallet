using System;
using MedWallet.DataModels.Interfaces;
using MedWalletAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedWalletAPI.Controllers
{
    [ApiController]
    public class UserAccountController: ControllerBase
    {
        private IUserAccountDataSource _dataSource;
        public UserAccountController(IUserAccountDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        [HttpGet()]
        [Route("UserAccount/GetDataSourceDescription")]
        public string GetDataSourceDescription()
        {
            return _dataSource.Description;
        }
       
        [HttpGet()]
        [Route("UserAccount/GetAllAccounts")]
        public List<UserAccount> GetAllAccounts()
        {
            return _dataSource.GetAllAccounts();
        }

        [HttpGet()]
        [Route("UserAccount/GetAccountById")]
        public UserAccount GetAccountById(int id)
        {
            return _dataSource.GetAccount(id);
        }

        [HttpPost()]
        [Route("UserAccount/AddNewAccount")]
        public UserAccount AddNewAccount(UserAccount acct)
        {
            return _dataSource.AddAccount(acct);
        }

        [HttpPost()]
        [Route("UserAccount/UpdateAccount")]
        public UserAccount UpdateAccount(UserAccount acct)
        {
            return _dataSource.UpdateAccount(acct);
        }

        [HttpDelete()]
        [Route("UserAccount/DeleteAccount")]
        public bool DeleteAccount(int id)
        {
            return _dataSource.DeleteAccount(id);
        }
    }
}

