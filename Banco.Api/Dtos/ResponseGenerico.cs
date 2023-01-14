using System.Dynamic;
using System.Net;

namespace Brasil.Api.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErrorRetorno { get; set; }


    }
}
