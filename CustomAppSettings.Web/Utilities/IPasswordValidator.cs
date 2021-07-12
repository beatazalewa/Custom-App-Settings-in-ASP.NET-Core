namespace CustomAppSettings.Web.Utilities
{
    public interface IPasswordValidator
    {
        public string Pattern { get; set; }
        public string PasswordString { get; set;}
        public int PasswordLength { get; set;}
    }
}