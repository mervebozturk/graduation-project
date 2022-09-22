using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace PycApi.Data
{
    public class CategoryMap : ClassMapping<Category>  //burada databasedeki verilerimizi tanıtıyoruz.
    {
        public CategoryMap()
        {
            
            Table("category");

            
            Id(c => c.CategoryId, i =>
            {
                i.Column("categoryid");
                i.Type(NHibernateUtil.Int64);
                i.UnsavedValue(0);
                i.Generator(Generators.Increment);
            });

            
            Property(c => c.CategoryName, c =>
            {
                c.Column("categoryname");
                c.Type(NHibernateUtil.String);
                c.NotNullable(false);
            });

            
        }
    }
}
