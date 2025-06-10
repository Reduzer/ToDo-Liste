namespace Shared.DTO.Put;

public class PutPasswordDTO
{
    public PutPasswordDTO(string sPassword, string sSalt)
    {
        this.sPassword = sPassword;
        this.sSalt = sSalt;
    }

    public string sPassword {get; private set; }
    public string sSalt { get; private set; }
}