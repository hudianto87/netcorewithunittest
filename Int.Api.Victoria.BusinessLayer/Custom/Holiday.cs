using Int.Api.Victoria.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace Int.Api.Victoria.BusinessLayer.Custom
{
    public class Holiday
    {
        private readonly DBContext dB;

        public Holiday(DBContext dBContext)
        {
            dB = dBContext;
        }
        public async Task<bool> IsHoliday(DateTime date, int currency)
        {
            bool _IsHoliday = false;
            _IsHoliday = await dB.IsTrues.FromSqlRaw("select dbo.fn_THoliday_CheckIsHoliday({0},{1}) as checkholiday", currency, date).Select(x => x.checkholiday).FirstOrDefaultAsync();

            return _IsHoliday;
        }

        public DateTime AddDate(DateTime date, short value, int iDCurrency)
        {
            Task<bool> checkHoliday;
            short step = (short)(value > 0 ? 1 : -1);

            while (value != 0)
            {
                date = date.AddDays(step);
                //if (!IsHoliday(date, iDCurrency))
                //    value -= step;
                checkHoliday = IsHoliday(date, iDCurrency);
                if (checkHoliday.Result == false)
                    value -= step;
            }

            return date;
        }
    }
}
