using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace KayisiMvcWEB.Entitiy
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
           var Kategoriler = new List<Category>()
            {
                new Category(){Name="Kuru Kayısı" , Description="Kuru Kayısı Ürünleri"},
                new Category(){Name="Yaş Kayısı" , Description=" Yaş Kayısı Ürünleri"}
            };

            foreach (var kategori in Kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

           var Urunler = new List<Product>()
            {
                new Product(){Name="Kuru Sarı Kayısı", Description=" Altın renginde, altın şekilde ve altın kadar değerli… Ülkemiz topraklarında yetişen en lezzetli meyvelerden bir tanesi de kayısıdır. Bereketli ürün vermesi ile üreticisinin yüzünü güldüren, muhteşem tadıyla tüketicisini kendine bağlayan ve sağlık katan bir meyvedir. Kayısı hem taze hali hem de kuruşuyla mutfaklarımıza, sofralarımıza sık sık konuk oluyor. Bu nedenle kuru kayısı faydaları, en az tadı kadar on planda! ", Price=30, Stock=100 ,IsApproved=true,CategoryId=1, IsHome=true, Image="1.jpg"},
                new Product(){Name="Gün Kurusu", Description=" Gün Kurusu Ürünü", Price=50, Stock=100 ,IsApproved=true,CategoryId=1, IsHome=false, Image="2.jpg" },
                new Product(){Name="Komposto Kurusu", Description=" Komposto Kurusu Ürünü", Price=10, Stock=100 ,IsApproved=true,CategoryId=1, Image="3.jpg" },
                new Product(){Name="Yeşil Kayısı", Description=" Yeşil Kayısı Ürünü", Price=10, Stock=100 ,IsApproved=true,CategoryId=2, IsHome=true, Image="4.jpg" },
                new Product(){Name="Hasanbey Kayısısı", Description=" Hasanbey Kayısısı Ürünü", Price=30, Stock=100 ,IsApproved=true,CategoryId=2, Image="5.jpg" },
                new Product(){Name="Olgun Kayısı", Description=" Olgun Kayısı Ürünü", Price=10, Stock=100 ,IsApproved=true,CategoryId=2, IsHome=true, Image="6.jpg" }
            };

            foreach (var urun in Urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            
            base.Seed(context);
        }
    }
}