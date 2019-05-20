namespace Data.Models.Common
{
    public class BaseException
    {
        public int Id { get; set; }
        public bool HasError { get; set; }
        public bool IsWarning { get; set; }
        public string Message { get; set; }
    }
}