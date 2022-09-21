using Int.Victoria.Scheduler.Context;
using Int.Victoria.Scheduler.Models;


namespace Int.Victoria.Scheduler.BusinessObject
{
    public class BOBatchLogger
    {
        private readonly DBContext dBContext;
        public BOBatchLogger(DBContext _context)
        {
            dBContext = _context;
        }
        public void SaveLog(string batchType, string direction, string fileName, string senderHost, string receiverHost,
                             string destPath, DateTime createdTime, string exception)
        {
            try
            {
                TextCimbBatchLog textCimbBatchLog = new TextCimbBatchLog()
                {
                    BatchType = batchType,
                    Direction = direction,
                    FileName = fileName,
                    SenderHost = senderHost,
                    ReceiverHost = receiverHost,
                    DestPath = destPath,
                    CreatedTime = createdTime,
                    Exception = exception
                };

                dBContext.TextCimbBatchLogs.Add(textCimbBatchLog);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
