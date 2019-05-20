using Data.Models.Common;

namespace Data.Models
{
    public class User :BaseClass
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}