using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shared.Entity
{
	public class User
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)] public long nID { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sGivenName { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sLastName { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sEMail { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sInAppUserName { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sSymbol { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sDepartment { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public float dWorkload { get; private set; }
	}
}
