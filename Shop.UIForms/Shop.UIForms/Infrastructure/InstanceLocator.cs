using Shop.UIForms.ViewModels;

namespace Shop.UIForms.Infrastructure
{

    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }


}
