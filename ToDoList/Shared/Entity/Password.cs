using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entity
{
	public class Password
	{
		public Password(string sPassword, string sSalt)
		{
			this.sPassword = sPassword;
			this.sSalt = sSalt;
		}

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)] public long nID {get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sPassword {get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sSalt { get; private set; }
	}
}
