using System;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;

namespace SampleFreshMVVM.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class FirstPageModel : FreshBasePageModel
    {
        public ICommand NavigateToSecond => new Command(async () => await NavigateToSecondPage());

        public string CustomHeader { get; set; }

        public FirstPageModel()
        {
        }

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);

            if (returnedData != null)
            {
                if (returnedData is string)
                {
                    CustomHeader = (string)returnedData;
                }
            }
        }

        private async Task NavigateToSecondPage()
        {
            await CoreMethods.PushPageModel<SecondPageModel>(CustomHeader, true);
        }
    }
}
