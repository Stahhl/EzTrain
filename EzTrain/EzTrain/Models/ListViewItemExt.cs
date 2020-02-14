using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EzTrain.Models
{
    public class ListViewItemExt : ListViewItem
    {
        private SfListView listView;

        public ListViewItemExt(SfListView listView, object selectedItem)
        {
            this.listView = listView;
        }
        public void ChangeColor(Color color)
        {
            this.BackgroundColor = color;
        }
    }
}
