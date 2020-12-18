using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasDetPagesKru
{
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            aboutList.ItemSelected += AboutList_ItemSelected;
            profileImage.Source = ImageSource.FromFile("img.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.Glava1);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
            
        }

        private void AboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }

        private List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 1",
                TargetPage = typeof(Views.Glava1),
                ImagePath = "1.jpg"
            }) ;
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 2",
                TargetPage = typeof(Views.Glava2),
                ImagePath = "2.jpg"
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 3",
                TargetPage = typeof(Views.Glava3),
                ImagePath = "3.png"
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 4",
                TargetPage = typeof(Views.Glava4),
                ImagePath = "4.jpg"
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 5",
                TargetPage = typeof(Views.Glava5),
                ImagePath = "5.jpg"
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 6",
                TargetPage = typeof(Views.Glava6),
                ImagePath = "6.png"
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 7",
                TargetPage = typeof(Views.Glava7),
                ImagePath = "7.jpg"
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 8",
                TargetPage = typeof(Views.Glava8),
                ImagePath = "8.png"
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 9",
                TargetPage = typeof(Views.Glava9),
                ImagePath = "9.png"
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Глава 10",
                TargetPage = typeof(Views.Glava10),
                ImagePath = "10.png"
            });
            return list;
        }

        


    }
}
