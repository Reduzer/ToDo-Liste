using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entity
{
	public class Project
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)] public long nID { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sName { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sDescription { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public DateTime oStart { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public DateTime oPlanedEnd { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public DateTime oAcctualEnd { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public IEnumerable<long> vnUserIDs { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public IEnumerable<long> tnTaskIDs { get; private set; }
	}
}
