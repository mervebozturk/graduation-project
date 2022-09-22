using PycApi.Base;

namespace PycApi.Service
{
    public interface ITokenService
    {
        BaseResponse<TokenResponse> GenerateToken(TokenRequest tokenRequest);
    }
}
