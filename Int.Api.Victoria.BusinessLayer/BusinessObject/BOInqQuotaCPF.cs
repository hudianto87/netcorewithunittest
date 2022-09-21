using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.BusinessLayer.Interface;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOInqQuotaCPF : IBOInqQuotaCPF
    {
        private readonly DBContext dbContext;
        private readonly Reference BOReference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly BOLogger boLogger;
        public BOInqQuotaCPF(DBContext dB)
        {
            dbContext = dB;
            BOReference = new Reference(dbContext);
            responseCode = new();
            boLogger = new(dB);
        }
        public async Task<ResultBase<BMRInqQuotaCPF>> GetDataQuotaCPF(BMInqQuotaCPF request)
        {
            var result = new ResultBase<BMRInqQuotaCPF>
            {
                Data = new()
            };

            double tempAmount = (double)request.Amount;
            try
            {
                #region Validation Get Data Product And Channel
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

                #region Process Get Quota And Validation
                var getQuota = await BOReference.GetQuotaCPF(getDataProduct.Idproduct);
                if (getQuota == 0)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS084);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS084.ToString();
                    return result;
                }

                if (getQuota < tempAmount)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS085);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS085.ToString();
                    return result;
                }
                #endregion

                result.Data.ProductCode = request.ProductCode;
                result.Data.AvailableQuota = getQuota;
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.Message;
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                await boLogger.SaveLog("IN", request.ChannelID.Trim(), "Service Inquiry Quota CPF", "InqQuotaCPF", "", null,
                                    "", JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, request.ChannelID.Trim(), DateTime.Now);
            }
            return result;
        }
    }
}
