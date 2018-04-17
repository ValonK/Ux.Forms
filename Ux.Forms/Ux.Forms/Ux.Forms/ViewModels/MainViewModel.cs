using Xamarin.Forms;

namespace Ux.Forms.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public Command<object> YouTubeCommand {
            get {
                return new Command<object>(o => {

                });
            }
        }
    }
}
