using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entity
{
	internal class Password
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)] public long nID {get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sPassword {get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sSalt { get; private set; }
	}
}
