using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace PycApi.Data
{
    public class ProductMap : ClassMapping<Product> //burada databasedeki verilerimizi tanıtıyoruz.
    {
        public ProductMap()
        {

            Table("product");


            Property(c => c.ProductName, c =>
            {
                c.Column("productname");
                c.Type(NHibernateUtil.String);
                c.Length(100);
                c.NotNullable(false);
            });

            Property(c => c.ProductDescription, c =>
            {
                c.Column("productdescription");
                c.Type(NHibernateUtil.String);
                c.Length(500);
                c.NotNullable(false);
            });


            Property(c => c.ProductColour, l =>
            {
                l.Column("productcolour");
                l.Type(NHibernateUtil.String);
                l.NotNullable(false);
            });


            Property(c => c.ProductBrand, l =>
            {
                l.Column("productbrand");
                l.Type(NHibernateUtil.String);
                l.NotNullable(false);
            });


            Property(c => c.ProductPrice, i =>
            {
                i.Column("productprice");
                i.Type(NHibernateUtil.Int64);
                i.NotNullable(false);

            });

            Property(c => c.CategoryId, i =>
            {
                i.Column("categoryid");
                i.Type(NHibernateUtil.Int64);
                i.NotNullable(false);

            });

            Id(x => x.ProductId, x =>
            {
                x.Type(NHibernateUtil.Int64);
                x.Column("productid");
                x.UnsavedValue(0);
                x.Generator(Generators.Increment);
            });


        }
    }
}