using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1.Data.ViewModel
{
    public class BookViewModel : DependencyObject
    {
        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(BookViewModel), new PropertyMetadata(null));

        public BookViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Repositories.GetLabriary());
        }
    }
}
