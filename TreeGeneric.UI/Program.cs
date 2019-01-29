using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGeneric.BussinessLogic;
using TreeGeneric.Data;

namespace TreeGeneric.UI
{
    public static class Program
    {
        [STAThread]
       public static void Main() { 
         var builder = new ContainerBuilder();
            builder.RegisterType<ApplicationDbContext>().As<ApplicationDbContext>();

            //  builder.RegisterType<Repository<TreeGeneric.Model.Region>>().As<IRepository<TreeGeneric.Model.Region>>();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            //servisleri yapman lazım

            builder.RegisterType<RegionService>().As<IRegionService>();
            
            builder.RegisterType<PlantingService>().As<IPlantingService>();
           
            builder.RegisterType<TreeTypeService>().As<ITreeTypeService>();
            
            builder.RegisterType<DonationService>().As<IDonationService>();
            
            builder.RegisterType<PostService>().As<IPostService>();
            
            builder.RegisterType<UserService>().As<IUserService>();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(scope));

            }
        }
    }
}
