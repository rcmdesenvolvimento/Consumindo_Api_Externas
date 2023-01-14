using Brasil.Api.Dtos;

namespace Brasil.Api.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscaEndereco(string cep);
    }
}