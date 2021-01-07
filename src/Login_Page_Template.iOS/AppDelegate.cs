using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;

namespace Login_Page_Template.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : MvxFormsApplicationDelegate<Setup, Core.App, UI.App>
    {
    }
}
