using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using UwizardWPF.Entities;
using UwizardWPF.Server;
using UwizardWPF.ViewModel;

namespace UwizardWPF
{
    public class Setup
    {
        public void Register()
        {
            var container = SimpleIoc.Default;
            ServiceLocator.SetLocatorProvider(() => container);
            DoRegistration(container);
            RegisterSchema(container.GetInstance<ISQLiteDatabase>());
        }

        protected virtual void DoRegistration(SimpleIoc container)
        {
            RegisterModels(container);
            RegisterViewModels(container);
            RegisterServices(container);
        }

        private void RegisterServices(SimpleIoc container)
        {
            container.Register<ISQLiteDatabase, SQLiteDatabase>();
        }

        private void RegisterViewModels(SimpleIoc container)
        {
            container.Register<MainViewModel>();
            container.Register<GameManagementViewModel>();
        }

        private void RegisterModels(SimpleIoc container)
        {
        }

        protected void RegisterSchema(ISQLiteDatabase db)
        {
            db.DoSync(connection =>
            {
                connection.CreateTable<WiiUDisk>();

            });
        }
    }
}
