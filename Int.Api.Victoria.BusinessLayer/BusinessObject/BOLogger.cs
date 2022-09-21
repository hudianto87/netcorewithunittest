using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOLogger
    {
        private readonly DBContext db;
        public BOLogger(DBContext context)
        {
            db = context;
        }
        public async Task<TExt_Victoria_APILog> SaveLog(string direction, string channelID, string appModul, string serviceName, string rqUID, long? idTransaction,
                                                       string CIF, string requestData, string responseData, string responseCode, string responseDescription,
                                                       string exception, string sysCreatedBy, DateTime sysCreatedTime)
        {
            try
            {
                TExt_Victoria_APILog textVictoriaLog = new()
                {
                    Direction = direction,
                    ChannelId = channelID,
                    AppModul = appModul,
                    ServiceName = serviceName,
                    RqUid = rqUID,
                    Idtransaction = idTransaction,
                    Cif = CIF,
                    RequestData = requestData,
                    ResponseData = responseData,
                    ResponseCode = responseCode,
                    ResponseDescription = responseDescription,
                    Exception = exception,
                    SysCreatedBy = sysCreatedBy,
                    SysCreatedTime = sysCreatedTime
                };

                await db.TExt_Victoria_APILogs.AddAsync(textVictoriaLog);
                await db.SaveChangesAsync();

                return textVictoriaLog;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
