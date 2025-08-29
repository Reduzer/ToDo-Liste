using DatabaseService.Context;
using DatabaseService.DBServices;

namespace DatabaseService.Services
{
	public class PasswordService : PasswordService.PasswordServiceBase
	{
		private DBPasswordService oService;

		public PasswordService(PasswordContext oContext)
		{
			oService = new DBPasswordService(oContext);
		}


	}
}
