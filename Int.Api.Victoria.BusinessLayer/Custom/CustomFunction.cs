namespace Int.Api.Victoria.BusinessLayer.Custom
{
    public class CustomFunction
    {
        public string ConvertDateToStringFormatESB(DateTime ParamDate)
        {
            string _returnDate = ParamDate.ToString("yyyy-MM-ddTHH:mm:ss");
            return _returnDate;
        }

        public double BuildAmount(double value, int digit)
        {
            double _Digit = Convert.ToDouble("1".ToString().PadRight(digit + 1, '0'));
            return Math.Round((value * _Digit));
        }

        public static Exception GetInnermostException(Exception ex)
        {
            if (ex != null)
                while (ex.InnerException != null)
                    ex = ex.InnerException;
            return ex;
        }

        public static string GetInnermostExceptionMessage(Exception ex)
        {
            var _ex = GetInnermostException(ex);
            if (_ex != null)
                return _ex.Message;
            else
                return null;
        }
    }
}
