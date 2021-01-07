using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Login_Page_Template.Core.ViewModels;

namespace Login_Page_Template.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<LoginViewModel>();
        }
    }
}
