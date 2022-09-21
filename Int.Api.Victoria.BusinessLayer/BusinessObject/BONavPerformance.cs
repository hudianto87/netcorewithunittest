using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BONavPerformance
    {
        private readonly DBContext dbContext;
        private readonly Reference BOReference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly BOLogger boLogger;
        public BONavPerformance(DBContext db)
        {
            dbContext = db;
            BOReference = new Reference(dbContext);
            responseCode = new ResponseCode.ResponseCode();
            boLogger = new(db);
        }
        public async Task<ResultBase<BMRNAVPerformance>> InquiryNAV(BMNAVPerformance request)
        {
            var result = new ResultBase<BMRNAVPerformance>()
            {
                Data = new()
            };

            List<NAVPerformance> ListdataNAV = new();
            string[] ListRangeType = new string[] { "D", "M", "Y" };
            DateTime date = DateTime.Now;
            DateTime resultDate;
            try
            {
                #region Validation Request Get Data Channel And Product Code
                VTreferenceDetail? getDataChannel = await BOReference.GetChannel(request.ChannelID.Trim());
                if (getDataChannel == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }

                Tproduct? getDataProduct = await BOReference.GetProductByProductcode(request.ProductCode.Trim());
                if (getDataProduct == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS007);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS007.ToString();
                    return result;
                }
                #endregion

                #region Request Validation Range Type NAV
                var checkRangeType = Array.FindIndex(ListRangeType, x => x.Equals(request.RangeType.ToUpper().Trim()));
                if (checkRangeType == -1)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS087);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS087.ToString();
                    return result;
                }
                #endregion

                #region Validation Response Get Data NAV
                if (request.RangeValue == 0)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS086);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS086.ToString();
                    return result;
                }
                #endregion

                switch (request.RangeType.ToUpper().Trim())
                {
                    case "D":
                        for (int i = 1; i <= request.RangeValue; i++)
                        {
                            NAVPerformance dataNAV = new();
                            resultDate = await BOReference.CheckHoliday(DateTime.Now.ToString("yyyy-MM-dd"), -i);

                            Tnav getDataNAV = await BOReference.GetDataNavByProductAndDate(getDataProduct.Idproduct, resultDate);

                            dataNAV.Amount = getDataNAV == null ? 0 : getDataNAV.Value;
                            dataNAV.Date = resultDate;

                            ListdataNAV.Add(dataNAV);
                        }
                        break;
                    case "M":
                        for (int i = 0; i <= request.RangeValue; i++)
                        {
                            NAVPerformance dataNAV = new();

                            resultDate = await BOReference.CheckHoliday(date.AddMonths(-i).ToString("yyyy-MM-dd"), -1);

                            Tnav getDataNAV = await BOReference.GetDataNavByProductAndDate(getDataProduct.Idproduct, resultDate);

                            dataNAV.Amount = getDataNAV == null ? 0 : getDataNAV.Value;
                            dataNAV.Date = resultDate;

                            ListdataNAV.Add(dataNAV);
                        }
                        break;
                    case "Y":
                        for (int i = 0; i <= request.RangeValue; i++)
                        {
                            NAVPerformance dataNAV = new();

                            resultDate = await BOReference.CheckHoliday(date.AddYears(-i).ToString("yyyy-MM-dd"), -1);

                            Tnav getDataNAV = await BOReference.GetDataNavByProductAndDate(getDataProduct.Idproduct, resultDate);

                            dataNAV.Amount = getDataNAV == null ? 0 : getDataNAV.Value;
                            dataNAV.Date = resultDate;

                            ListdataNAV.Add(dataNAV);
                        }
                        break;
                    default:
                        break;
                }

                result.Data.Performances.AddRange(ListdataNAV);
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS999);
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                await boLogger.SaveLog("IN", request.ChannelID.Trim(), "Service NAV Performance", "NavPerformance", "", null,
                                    "", JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, request.ChannelID.Trim(), DateTime.Now);
            }
            return result;
        }
    }
}