using System;
using Autofac;

namespace GalleryApp.iOS
{
    public class Bootstrapper : GalleryApp.Boostrapper
    {
        protected override void Initialize()
        {
            base.Initialize();

            ContainerBuilder.RegisterType<PhotoImporter>().As<IPhotoImporter>().SingleInstance();
        }
    }
}
