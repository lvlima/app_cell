using System;
using System.Collections.Generic;
using app_cell.Pagina;

using Xamarin.Forms;

namespace app_cell.Menu
{
    public partial class Master : MasterDetailPage

    {
        public Master()
        {
            InitializeComponent();
        }

        public void GoTextCellPage (object sender, EventArgs args)
        {
            Detail = new NavigationPage(new TextCellPage());
            IsPresented = false;
        }

        public void GoImageCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ImageCellPage());
            IsPresented = false;
        }

        public void GoEntryCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new EntryCellPage());
            IsPresented = false;
        }

        public void GoSwitchCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new SwitchCellPage());
            IsPresented = false;
        }

        public void GoViewCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ViewCellPage());
            IsPresented = false;
        }

        public void GoListViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ListViewPage());
            IsPresented = false;
        }

        public void GoListViewButtonPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ListViewButtonPage());
            IsPresented = false;
        }
    }
}
