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

namespace lab_9
{
    public partial class MainWindow : Window
    {
        private RightTriangle tri1;
        private RightTriangle tri2;
        public MainWindow()
        {
            InitializeComponent();
            tri1 = new RightTriangle();
            tri2 = new RightTriangle();
        }

        private void SideA_Changed(object sender, TextChangedEventArgs e)
        {
            double value;
            if (double.TryParse(SideA.Text, out value) && value > 0)
            {
                tri1.A = value;
                if (tri1)
                {
                    Tri1.Text = "Площадь 1\nтреугольника:\n" + (double)tri1;
                    return;
                }
            }
            Tri1.Text = "Треугольник не существует!";
        }

        private void SideB_Changed(object sender, TextChangedEventArgs e)
        {
            double value;
            if (double.TryParse(SideB.Text, out value) && value > 0)
            {
                tri1.B = value;
                if (tri1)
                {
                    Tri1.Text = "Площадь 1\nтреугольника:\n" + (double)tri1;
                    return;
                }
            } 
            Tri1.Text = "Треугольник не существует!";
        }

        private void SideA2_Changed(object sender, TextChangedEventArgs e)
        {
            double value;
            if (double.TryParse(SideA_2.Text, out value) && value > 0)
            {
                tri2.A = value;
                if (tri2)
                {
                    Tri2.Text = "Площадь 2\nтреугольника:\n" + tri2.CalcArea();
                    return;
                }
            }
            Tri2.Text = "Треугольник не существует!";
        }

        private void SideB2_Changed(object sender, TextChangedEventArgs e)
        {
            double value;
            if (double.TryParse(SideB_2.Text, out value) && value > 0)
            {
                tri2.B = value;
                if (tri2)
                {
                    Tri2.Text = "Площадь 2\nтреугольника:\n" + tri2.CalcArea();
                    return;
                }
            }
            Tri2.Text = "Треугольник не существует!";
        }

        private void Plus_1_Click(object sender, RoutedEventArgs e)
        {
            if (!Tri1.Text.EndsWith('!') && tri1)
            {
                tri1++;
                Tri1.Text = "Площадь 1\nтреугольника:\n" + (double)tri1;
                SideA.Text = tri1.A.ToString();
                SideB.Text = tri1.B.ToString();
            }
            else
            {
                Status.Text = "Треугольник 1 не существует!";
            }
        }

        private void Minus_1_Click(object sender, RoutedEventArgs e)
        {
            if (!Tri1.Text.EndsWith('!') && tri1)
            {
                tri1--;
                Tri1.Text = "Площадь 1\nтреугольника:\n" + (double)tri1;
                SideA.Text = tri1.A.ToString();
                SideB.Text = tri1.B.ToString();
            }
            else
            {
                Status.Text = "Треугольник 1 не существует!";
            }
        }

        private void Plus_2_Click(object sender, RoutedEventArgs e)
        {
            if (!Tri2.Text.EndsWith('!') && tri2)
            {
                tri2++;
                Tri2.Text = "Площадь 2\nтреугольника:\n" + tri2.CalcArea();
                SideA_2.Text = tri2.A.ToString();
                SideB_2.Text = tri2.B.ToString();
            }
            else
            {
                Status.Text = "Треугольник 2 не существует!";
            }
        }

        private void Minus_2_Click(object sender, RoutedEventArgs e)
        {
            if (!Tri2.Text.EndsWith('!') && tri2)
            {
                tri2--;
                Tri2.Text = "Площадь 2\nтреугольника:\n" + tri2.CalcArea();
                SideA_2.Text = tri2.A.ToString();
                SideB_2.Text = tri2.B.ToString();
            }
            else
            {
                Status.Text = "Треугольник 2 не существует!";
            }
        }

        private void Compare_Click(object sender, RoutedEventArgs e)
        {
            if (!Tri2.Text.EndsWith('!') && !Tri1.Text.EndsWith('!')
                && tri1 && tri2)
            {
                if (tri1 >= tri2)
                {
                    Status.Text = "Площадь первого треугольника больше" +
                        " или равна второму";
                }
                else
                {
                    Status.Text = "Площадь второго треугольника больше" +
                        " первого";
                }
            }
            else
            {
                Status.Text = "Один из треугольников не существует";
            }
        }
    }
}