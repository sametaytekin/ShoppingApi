using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApi.Base.Response
{
    public partial class BaseResponse
    {
        public BaseResponse()
        {

        }
    }

    public partial class BaseResponse<T>
    {
        public bool Success { get; set; }
        public T Result { get; set; }
        public string Message { get; set; }

        public BaseResponse(bool isSuccess)
        {
            Success = isSuccess;
            Result = default;
            Message = isSuccess ?  "success" :  "fault";
        }

        public BaseResponse(string message)
        {

        }

    }

}
