using Int.Victoria.Scheduler.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Int.Victoria.Scheduler.BindingModelResult;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Int.Victoria.Scheduler.BusinessObject
{
    public class BOProductCatalog
    {        
        public void GenerateProductCatalog()
        {
            FTPHelper fTPHelper = new FTPHelper();

            DBContext dB = new DBContext();
            BOBatchLogger batchLog = new BOBatchLogger(dB);
            string msg = string.Empty;
            DateTime datelog = DateTime.Now;

            string prefix = string.Empty;
            string filename = string.Empty ;
            string ftpdestination = string.Empty;
            string ftpHost = string.Empty;
            int ftpPort;
            bool ftpSSLEnable;
            string ftp = string.Empty;
            string ext = string.Empty;
            string filejson = string.Empty;
            string ftpUsername = string.Empty;
            string ftpPassword = string.Empty;
            string local = string.Empty;

            try
            {
                ext = ConfigurationManager.AppSettings["extension"].ToString();
                prefix = ConfigurationManager.AppSettings["Prefix"].ToString();
                ftp = ConfigurationManager.AppSettings["ftpHost"].ToString();
                ftpHost = ftp.Substring(0, ftp.IndexOf(':'));
                ftpPort = int.Parse(ftp.Substring(ftp.IndexOf(':') + 1));
                ftpUsername = ConfigurationManager.AppSettings["ftpUser"].ToString();
                ftpPassword = ConfigurationManager.AppSettings["ftpPass"].ToString();
                ftpSSLEnable = Boolean.Parse(ConfigurationManager.AppSettings["ftpSSLEnable"].ToString());
                ftpdestination = ConfigurationManager.AppSettings["ftpDestination"].ToString();
                filename = prefix + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ext;
                local = ConfigurationManager.AppSettings["localPath"].ToString();

                List<BMRProductCatalog> bMRProductCatalogs = new List<BMRProductCatalog>();

                var listprod = dB.productCatalogViewModel.FromSqlRaw("Exec Integration_Batch_ProductCatalog_Mobile").ToList();

                if(listprod.Count > 0)
                {
                    foreach (var item in listprod)
                    {
                        BMRProductCatalog bMRProductCatalog = new BMRProductCatalog()
                        {
                            ProductCode = item.ProductCode,
                            ProductName = item.ProductName,
                            RiskProfileProductID = item.RiskProfileProductID,
                            RiskProfileProductName = item.RiskProfileProductName,
                            FundHouseCode = item.FundHouseCode,
                            FundHouseName = item.FundHouseName,
                            Currency = item.Currency,
                            NAV = item.NAV,
                            NAVDate = item.NAVDate,
                            Tax = item.Tax,
                            Category = item.Category,
                            MinSub = item.MinSub,
                            MinRed = item.MinRed,
                            MinSwt = item.MinSwt,
                            SubsFee = item.SubsFee,
                            RedFee = item.RedFee,
                            SwtFee = item.SwtFee,
                            EligibleForCrisp = item.EligibleForCrisp,
                            EligibleForCrispPlus = item.EligibleForCrispPlus,
                            OneYear = item.OneYear,
                            OneMonth = item.OneMonth,
                            MFType = item.MFType,
                            PeriodeImbalHasil = item.PeriodeImbalHasil,
                            MasaPenawaranStart = item.MasaPenawaranStart,
                            MasaPenawaranEnd = item.MasaPenawaranEnd,
                            ExitWindowStart = item.ExitWindowStart,
                            ExitWindowEnd = item.ExitWindowEnd,
                            InitialNAV = item.InitialNAV,
                            IsActive = item.IsActive,
                            SubsFeeEmployee = item.SubsFeeEmployee,
                            RedFeeEmployee = item.RedFeeEmployee,
                            SwtFeeEmployee = item.SwtFeeEmployee,
                            ExpiredDate = item.ExpiredDate,
                            CutOffTime = item.CutOffTime
                        };

                        bMRProductCatalogs.Add(bMRProductCatalog);
                    }

                    filejson = JsonConvert.SerializeObject(bMRProductCatalogs).ToString();

                    fTPHelper.WinscpUpload(ftpHost, ftpPort, ftpdestination, ftpUsername, ftpPassword, ftpSSLEnable, local + filename);
                }                
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                batchLog.SaveLog("GenerateProductCatalog", "OUT", filename, "WMS", "Victoria", ftpdestination, datelog, msg);
            }
        }

    }
}
