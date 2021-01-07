using Android.App;
using MvvmCross.Forms.Platforms.Android.Core;

#if DEBUG
[assembly: Application(Debuggable = true)]
#else
[assembly: Application(Debuggable = false)]
#endif

namespace Login_Page_Template.Droid
{
    public class Setup : MvxFormsAndroidSetup<Core.App, UI.App>
    {
    }
}
