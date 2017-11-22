namespace TestNetCore.Constants
{
    public static class Misc
    {
		public enum DatabaseType
		{
			Mysql = 1
		}

        public enum LoginStatus
        {
            Failed = 0,
            OK = 1
        }

        public enum Roles
        {
            Administrator = 1,
            User = 2
        }
    }
}
