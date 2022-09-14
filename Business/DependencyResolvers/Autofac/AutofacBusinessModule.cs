using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    //Busines > Autofac packages added.
    // WepApi>Program.cs içerisinde değişiklik yapıldı.
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();  // SingleInstance: Data yok ... Tek bir instance milyonlarca kullanım..
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
