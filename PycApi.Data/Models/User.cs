using System;

namespace PycApi.Data //burada önce datalarımızı tanımlıyoruz.
{
    public class User
    {
        public virtual long Id { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string Role { get; set; }
        public virtual DateTime LastActivity { get; set; }

    }
}
