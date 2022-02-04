using MudSharp.Service.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudSharp.Service.Accounts
{
    public class AccountsService : IAccountsService
    {
        private readonly IAccountsRepository _accountsRepository;

        public AccountsService (IAccountsRepository accountsRepository) {
            _accountsRepository = accountsRepository;
        }

        public Account SaveAnAccount(int number)
        {
            return _accountsRepository.SaveAnAccount(number);
        }
    }
}
