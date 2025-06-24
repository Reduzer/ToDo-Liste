using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entity
{
	internal class Task
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)] public long nID { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sName { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public string sDescription { get; private set; }
		[DatabaseGenerated(DatabaseGeneratedOption.None)] public IEnumerable<long> vnAssignedEmployees { get; private set; }
	}
}
