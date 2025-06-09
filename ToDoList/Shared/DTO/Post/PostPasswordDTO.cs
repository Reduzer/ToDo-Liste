namespace Shared.DTO.Post;

public class PostPasswordDTO
{
    public PostPasswordDTO(string sPassword, string sSalt)
    {
        this.sPassword = sPassword;
        this.sSalt = sSalt;
    }

    public string sPassword {get; private set; }
    public string sSalt { get; private set; }
}