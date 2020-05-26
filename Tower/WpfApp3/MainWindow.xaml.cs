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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DockPanel b;
        
        public MainWindow()
        {
            InitializeComponent();

            bash.MouseLeftButtonDown += bash_Effect;
            bash2.MouseLeftButtonDown += bash_Effect;
            bash3.MouseLeftButtonDown += bash_Effect;

        }

        void bash_Effect(object sender, MouseButtonEventArgs e)
        {
            if(b != null)
            {
                b.Effect = null;
                b = null;
                return;
            }
            if(b == (DockPanel)sender)
            {
                
                b = null;
                return;
            }

            b = (DockPanel)sender;
            if (b.Children.Count > 0)
            {

                DropShadowEffect dropShadowEffect = new DropShadowEffect();
                dropShadowEffect.ShadowDepth = 0;
                dropShadowEffect.Color = Colors.Red;
                dropShadowEffect.Opacity = 20;
                dropShadowEffect.BlurRadius = 20;
                b.Effect = dropShadowEffect;
            }
        }
        private void Rent_Position(object sender, MouseButtonEventArgs e)
        {
            var bashnya = (DockPanel)sender;
            var disk = bashnya.Children.OfType<Rectangle>().ToList().LastOrDefault();
            if (b == null)
            {
                return;
            }
            var disk1 = b.Children.OfType<Rectangle>().ToList().LastOrDefault();

            if (disk == null || disk1.Width < disk.Width)
            {
               b.Children.Remove(disk1);
               bashnya.Children.Add(disk1);
                
            }
            else
            {
                MessageBox.Show("Нельзя ложить большой диск на маленький!");
                
            }
        }
    }
}


   

          
        
  

            



      

        
       
    

