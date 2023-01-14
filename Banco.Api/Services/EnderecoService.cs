using AutoMapper;
using Brasil.Api.Dtos;
using Brasil.Api.Interfaces;
using Brasil.Api.Models;

namespace Brasil.Api.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscaEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscaEnderecoPorCep(cep);
            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}
