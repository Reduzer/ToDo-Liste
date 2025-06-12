namespace Security
{
	public class SecurityHandler
	{
		private string sPassword { get; set; }
		public Hashing oHashing;
		private static SecurityHandler instance;

		private SecurityHandler()
		{
			oHashing = new Hashing();
		}
		private static SecurityHandler Instance
		{
			get{
				if(instance == null){
					instance = new SecurityHandler();
				}
				return instance;
			}
		}

		public string hashing()
		{
			return oHashing.Hash(sPassword);
		}
	}
}
