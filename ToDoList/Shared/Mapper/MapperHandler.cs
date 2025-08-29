using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Mapper
{
	public class MapperHandler
	{
		private static MapperHandler _instance;

		private PasswordMapper _oPasswordMapper;
		private ProjectMapper _oProjectMapper;
		private TaskMapper _oTaskMapper;
		private UserMapper _oUserMapper;

		private MapperHandler()
		{
			_oPasswordMapper = new PasswordMapper();
			_oProjectMapper = new ProjectMapper();
			_oTaskMapper = new TaskMapper();
			_oUserMapper = new UserMapper();
		}

		public static MapperHandler Instance{
			get
			{
				if(_instance == null){
					_instance = new MapperHandler();
				}

				return _instance;
			}
		}
		
		public TaskMapper GetTaskMapper()
		{
			return _oTaskMapper;
		}

		public ProjectMapper GetProjectMapper() 
		{
			return _oProjectMapper;
		}

		public PasswordMapper GetPasswordMapper()
		{
			return _oPasswordMapper;
		}

		public UserMapper GetUserMapper()
		{
			return _oUserMapper;
		}
	}
}
