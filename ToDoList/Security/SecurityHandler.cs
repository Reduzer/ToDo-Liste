namespace Security
{
	public class SecurityHandler
	{
		public Hashing oHashing;
		private static SecurityHandler instance;

		public SecurityHandler()
		{
			oHashing = new Hashing();
		}
		private static SecurityHandler Instance{
			get{
				if(instance == null){
					instance = new SecurityHandler();
				}
				return instance;
			}
		}

		public Hashing hashing()
		{
			return oHashing;
		}
	}
}
