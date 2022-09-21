using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.BusinessLayer.BusinessObject.Master;
using Int.Api.Victoria.BusinessLayer.Interface;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Newtonsoft.Json;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOProductCategory : IBOProductCategory
    {
        private readonly Reference boReference;
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly BOLogger boLogger;
        public BOProductCategory(DBContext db)
        {
            boReference = new(db);
            responseCode = new();
            boLogger = new(db);
        }
        public async Task<ResultBase<List<BMRProductCategory>>> ResultProductCategory(BMProductCategory request)
        {
            var result = new ResultBase<List<BMRProductCategory>>
            {
                Data = new()
            };

            try
            {
                List<VTreferenceDetail> getDataChannel = await boReference.GetReferenceByGroupname("TRefTransactionGenerator");
                VTreferenceDetail? DataChannel = new();
                if (getDataChannel != null)
                {
                    DataChannel = getDataChannel.Where(x => x.Display.Equals(request.ChannelID)).FirstOrDefault();
                }

                if (getDataChannel == null || DataChannel == null)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS018);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS018.ToString();
                    return result;
                }

                List<VTreferenceDetail> listProductCategory = await boReference.GetDataProductCategory();
                if (listProductCategory.Count == 0)
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS110);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS110.ToString();
                    return result;
                }

                for (int i = 0; i < listProductCategory.Count; i++)
                {
                    BMRProductCategory dataCategoryProduct = new()
                    {
                        CategoryID = listProductCategory[i].MainValue,
                        CategoryName = listProductCategory[i].Display
                    };
                    result.Data.Add(dataCategoryProduct);
                }
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS999);
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                await boLogger.SaveLog("IN", request.ChannelID.Trim(), "Service Product Category", "ProductCategory", "", null,
                                    "", JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, request.ChannelID.Trim(), DateTime.Now);
            }
            return result;
        }
    }
}
