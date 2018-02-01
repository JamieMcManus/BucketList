using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BucketList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        

        public MainWindow()
        {
            InitializeComponent();
            List<TodoItem> items = new List<TodoItem>();
        items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Desc = "Desc", Status = false, Type = "Event", DateAdded = DateTime.Now, EventDate = new DateTime(2018, 1, 1) });
            items.Add(new TodoItem() { Title = "Learn C#", Desc = "Desc", Status = false, Type = "Event", DateAdded = DateTime.Now, EventDate = new DateTime(2018, 1, 1) });
            items.Add(new TodoItem() { Title = "Wash the car", Desc = "Desc", Status = false, Type = "Event", DateAdded = DateTime.Now });


            icTodoList.ItemsSource = items;
           

            
            
        }
    }


    //Test for XAML formating
    public class TodoItem
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public string Type { get; set; }
        public DateTime EventDate { get; set; }
    }
}
 