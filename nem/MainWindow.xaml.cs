using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;
using System.IO;
using HelixToolkit.Wpf;

namespace nem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<GyongyikeNeni> gyongyineniBevasarloListaja = File.ReadAllLines("gyongyok.txt").Skip(1).Select(x => new GyongyikeNeni(x)).ToList();
        public MainWindow()
        {
            InitializeComponent();
            MittomenMi();
        }

        void MittomenMi()
        {
            int x = 1;
            foreach (var listaelem in gyongyineniBevasarloListaja)
            {
                CubeVisual3D gyongyineni3Dben = new CubeVisual3D();
                gyongyineni3Dben.SideLength = x;
                x++;
                
                
                if (x % 2 == 0)
                {
                    gyongyineni3Dben.Fill = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    gyongyineni3Dben.Fill = new SolidColorBrush(Colors.Blue);
                }
                ter.Children.Add(gyongyineni3Dben);
            }
        }

    }
}