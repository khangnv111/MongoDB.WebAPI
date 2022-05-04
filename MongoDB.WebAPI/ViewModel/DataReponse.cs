namespace MongoDB.WebAPI.ViewModel
{
    public class DataReponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }

        public DataReponse() { }
        public DataReponse(dynamic data)
        {
            Data = data;
            Message = "SUCCESS";
        }
        public DataReponse(int code, string mess)
        {
            Code = code;
            Message = mess;
        }

        public DataReponse(int code, string mess, dynamic data)
        {
            Code = code;
            Message = mess;
            Data = data;
        }
    }
}
