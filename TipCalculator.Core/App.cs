using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TipCalculator.Core.ViewModels;

namespace Factorial.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TipViewModel>();
        }
    }
}