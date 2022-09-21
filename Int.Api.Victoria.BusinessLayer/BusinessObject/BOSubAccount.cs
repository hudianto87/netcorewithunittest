using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOSubAccount
    {
        private readonly DBContext dB;

        public BOSubAccount(DBContext dBContext)
        {
            dB = dBContext;
        }

        public async Task<TsubAccount> TSubAccount(TsubAccount subAccount)
        {
            try
            {
                dB.TsubAccounts.Add(subAccount);
                await dB.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw;
            }            

            return subAccount;
        }
    }
}
