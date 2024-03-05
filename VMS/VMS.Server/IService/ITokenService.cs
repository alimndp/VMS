using VMS.Server.Entity;

namespace VMS.Server.IService
{
    public interface ITokenService
    {
        string CreateToken(ApplicationUser user);
    }
}
