using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Entity;
using Shared.DTO.Get;
using Shared.DTO.Post;
using Shared.DTO.Put;

namespace Database.Mapper
{
	internal class PasswordMapper
	{		
		public GetPasswordDTO GetPassword(Password oPasswordEntity)
     		{
     			return new GetPasswordDTO(
     				oPasswordEntity.sPassword,
     				oPasswordEntity.sSalt
     			);
     		}
		public Password PostPassword(PostPasswordDTO oPostPasswordDTO)
		{
			return new Password(
				oPostPasswordDTO.sPassword,
				oPostPasswordDTO.sSalt
			);
		}



		public PutPasswordDTO PutPassword(Password oPasswordEntity)
		{
			return new PutPasswordDTO(
				oPasswordEntity.sPassword,
				oPasswordEntity.sSalt
			);
		}
	}
}
