namespace BLL.Autorization.Abstract
{
    public interface IUserClaimsOptions
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public bool IsEnabled { get; set; }

    }
}