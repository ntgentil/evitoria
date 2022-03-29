using evitoriav2.Debugging;

namespace evitoriav2
{
    public class evitoriav2Consts
    {
        public const string LocalizationSourceName = "evitoriav2";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8c95fa1694e843b78a59313dfd9a17de";
    }
}
