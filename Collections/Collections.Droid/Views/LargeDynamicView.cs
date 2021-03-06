using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Collections.Core.ViewModels.Samples.LargeDynamic;

namespace Collections.Droid.Views
{
    [Activity(Label = "Large Dynamic", ScreenOrientation = ScreenOrientation.Portrait)]
    public class LargeDynamicView : MvxBindingActivityView<LargeDynamicViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_DynamicView);
        }
    }
}