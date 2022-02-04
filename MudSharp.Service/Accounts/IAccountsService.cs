using MudSharp.Service.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudSharp.Service
{
    public interface IAccountsService
    {
        Account SaveAnAccount(int number);
    }
}
