using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.Interface;
using Int.Api.Victoria.DataAccess.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOProductCatalog : IBOProductCatalog
    {
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly DBContext dbContext;
        private readonly BOLogger boLogger;
        public BOProductCatalog(DBContext db)
        {
            responseCode = new();
            dbContext = db;
            boLogger = new(db);
        }
        public async Task<ResultBase<List<BMRProductCatalog>>> InqProductCatalog(BMProductCatalog request)
        {
            var finalResult = new ResultBase<List<BMRProductCatalog>>()
            {
                Data = new()
            };

            try
            {
                var param1 = new SqlParameter("@ProductCategory", request.ProductCategory.Trim());
                var param2 = new SqlParameter("@ProductCode", request.ProductCode.Trim());
                var resultDataProdCatalog = await dbContext.productCatalogViewModel.FromSqlRaw("Exec Integration_Batch_ProductCatalog_Mobile @ProductCategory, @ProductCode ", param1, param2).ToListAsync();
                if (resultDataProdCatalog.Count > 0)
                {
                    for (int item = 0; item < resultDataProdCatalog.Count; item++)
                    {
                        BMRProductCatalog prodCatalog = new()
                        {
                            ProductCode = resultDataProdCatalog[item].ProductCode,
                            ProductName = resultDataProdCatalog[item].ProductName,
                            RiskProfileProductID = resultDataProdCatalog[item].RiskProfileProductID,
                            RiskProfileProductName = resultDataProdCatalog[item].RiskProfileProductName,
                            FundHouseCode = resultDataProdCatalog[item].FundHouseCode,
                            FundHouseName = resultDataProdCatalog[item].FundHouseName,
                            Currency = resultDataProdCatalog[item].Currency,
                            NAV = resultDataProdCatalog[item].NAV,
                            NAVDate = resultDataProdCatalog[item].NAVDate,
                            Tax = resultDataProdCatalog[item].Tax,
                            Category = resultDataProdCatalog[item].Category,
                            MinSub = resultDataProdCatalog[item].MinSub,
                            MinRed = resultDataProdCatalog[item].MinRed,
                            MinSwt = resultDataProdCatalog[item].MinSwt,
                            SubsFee = resultDataProdCatalog[item].SubsFee,
                            RedFee = resultDataProdCatalog[item].RedFee,
                            SwtFee = resultDataProdCatalog[item].SwtFee,
                            EligibleForCrisp = resultDataProdCatalog[item].EligibleForCrisp,
                            EligibleForCrispPlus = resultDataProdCatalog[item].EligibleForCrispPlus,
                            OneYear = resultDataProdCatalog[item].OneYear,
                            OneMonth = resultDataProdCatalog[item].OneMonth,
                            MFType = resultDataProdCatalog[item].MFType,
                            PeriodeImbalHasil = resultDataProdCatalog[item].PeriodeImbalHasil,
                            MasaPenawaranStart = resultDataProdCatalog[item].MasaPenawaranStart,
                            MasaPenawaranEnd = resultDataProdCatalog[item].MasaPenawaranEnd,
                            ExitWindowStart = resultDataProdCatalog[item].ExitWindowStart,
                            ExitWindowEnd = resultDataProdCatalog[item].ExitWindowEnd,
                            InitialNAV = resultDataProdCatalog[item].InitialNAV,
                            IsActive = resultDataProdCatalog[item].IsActive,
                            SubsFeeEmployee = resultDataProdCatalog[item].SubsFeeEmployee,
                            RedFeeEmployee = resultDataProdCatalog[item].RedFeeEmployee,
                            SwtFeeEmployee = resultDataProdCatalog[item].SwtFeeEmployee,
                            ExpiredDate = resultDataProdCatalog[item].ExpiredDate,
                            CutOffTime = resultDataProdCatalog[item].CutOffTime
                        };
                        finalResult.Data.Add(prodCatalog);
                    }
                }
                else
                {
                    finalResult.IsOk = false;
                    finalResult.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS109);
                    finalResult.ResponseCode = ResponseCode.ResponseCode.errorList.WMS109.ToString();
                    return finalResult;
                }
            }
            catch (Exception ex)
            {
                finalResult.IsOk = false;
                finalResult.Message = ex.Message;
                finalResult.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                await boLogger.SaveLog("IN", request.ChannelID.Trim(), "Service Product Catalog", "ProductCatalog", "", null,
                                    "", JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(request), finalResult.ResponseCode,
                                    finalResult.Message, finalResult.Message, request.ChannelID.Trim(), DateTime.Now);
            }

            return finalResult;
        }
    }
}
