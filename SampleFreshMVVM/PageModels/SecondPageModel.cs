using System;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;

namespace SampleFreshMVVM.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class SecondPageModel : FreshBasePageModel
    {
        public string CustomHeader { get; set; }

        public ICommand CloseCommand => new Command(async () => await ClosePage());

        public SecondPageModel()
        {
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            if (initData != null)
            {
                if (initData is string)
                {
                    CustomHeader = (string)initData;
                }
            }
        }

        private async Task ClosePage()
        {
            string data = "This data is coming from second pagemodel";
            await CoreMethods.PopPageModel(data, true);
        }
    }
}
