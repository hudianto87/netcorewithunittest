using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinSCP;
using System.IO;

namespace Int.Victoria.Scheduler.BusinessObject
{
    public class FTPHelper
    {
        private SessionOptions WinscpCreateSession(string host, int port, string remotepath, string username, string password, bool isUseSSL)
        {
            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Ftp,
                HostName = host,
                UserName = username,
                Password = password,
                PortNumber = port,
            };
            if (isUseSSL)
            {
                sessionOptions.FtpSecure = FtpSecure.Implicit;
                sessionOptions.GiveUpSecurityAndAcceptAnyTlsHostCertificate = true;
            }

            return sessionOptions;
        }
        public void WinscpUpload(string host, int port, string remotepath, string username, string password, bool isUseSSL, string localpath)
        {
            try
            {
                SessionOptions sessionOptions = WinscpCreateSession(host, port, remotepath, username, password, isUseSSL);

                using (Session session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    // Upload files
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;

                    TransferOperationResult transferResult;
                    transferResult = session.PutFiles(@localpath, remotepath, false, transferOptions);

                    // Throw on any error
                    transferResult.Check();

                    // Print results
                    //foreach (TransferEventArgs transfer in transferResult.Transfers)
                    //{
                    //    Console.WriteLine("Upload of {0} succeeded", transfer.FileName);
                    //}
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //Console.Write(ex.Message);
            }
        }
    }
}
