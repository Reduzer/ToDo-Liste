namespace Shared.DTO.Get;

public class GetPasswordDTO
{
    public GetPasswordDTO(string sPassword, string sSalt)
    {
        this.sPassword = sPassword;
        this.sSalt = sSalt;
    }

    public string sPassword {get; private set; }
    public string sSalt { get; private set; }
}