using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOCustomerRegInvestmentPlan
    {
        private readonly DBContext dB;

        public BOCustomerRegInvestmentPlan(DBContext dBContext)
        {
            dB = dBContext;
        }

        public async Task<TcustomerRegInvestmentPlan> CustomerRegInvestmentPlan(TcustomerRegInvestmentPlan tcustomerRegInvestmentPlan)
        {
            try
            {
                dB.TcustomerRegInvestmentPlans.Add(tcustomerRegInvestmentPlan);
                await dB.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw;
            }

            return tcustomerRegInvestmentPlan;
        }
    }
}
