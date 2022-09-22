using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace PycApi.Data
{
    public class UserMap : ClassMapping<User> //burada databasedeki verilerimizi tanıtıyoruz.
    {
        public UserMap()
        {

            Table("users");


            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int64);
                x.Column("Id");
                x.UnsavedValue(0);
                x.Generator(Generators.Increment);
            });

            Property(c => c.Email, c =>
            {
                c.Column("email");
                c.Type(NHibernateUtil.String);
                c.NotNullable(false);
            });

            Property(c => c.Password, c =>
            {
                c.Column("password");
                c.Type(NHibernateUtil.String);
                c.NotNullable(false);
            });

            Property(c => c.Role, c =>
            {
                c.Column("role");
                c.Type(NHibernateUtil.String);
                c.NotNullable(false);
            });

            Property(b => b.LastActivity, x =>
            {
                x.Type(NHibernateUtil.DateTime);
                x.NotNullable(true);
            });
        }
    }
}
