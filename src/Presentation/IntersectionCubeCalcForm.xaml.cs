using CubeIntersection.src.Application;
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
using System.Windows.Shapes;

namespace CubeIntersection.src.Presentation
{
    /// <summary>
    /// Lógica de interacción para IntersectionCubeCalcForm.xaml
    /// </summary>
    public partial class IntersectionCubeCalcForm : Window
    {
        public IntersectionCubeCalcForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

            private void Reset_Click(object sender, RoutedEventArgs e)
        {
            tbSize1.Text = string.Empty;
            tbSize2.Text = string.Empty;
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY1.Text = string.Empty;
            tbY2.Text = string.Empty;
            tbZ1.Text = string.Empty;
            tbZ2.Text = string.Empty;

            tbSol.Text = string.Empty;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double size1 = double.Parse(tbSize1.Text);
                double size2 = double.Parse(tbSize2.Text);
                double x1 = double.Parse(tbX1.Text);
                double y1 = double.Parse(tbY1.Text);
                double z1 = double.Parse(tbZ1.Text);
                double x2 = double.Parse(tbX2.Text);
                double y2 = double.Parse(tbY2.Text);
                double z2 = double.Parse(tbZ2.Text);

                IntersectionCubeService cubeService = new IntersectionCubeService(size1, x1, y1, z1, size2, x2, y2, z2);

                double volIntersection = cubeService.VolumenIntersection();

                if (volIntersection > 0)
                    tbSol.Text = "The cubes collide. Volume of the intersection: " + volIntersection;
                else
                    tbSol.Text = "The cubes don't collide";
            }
            catch (Exception ex)
            {
                tbSol.Text = ex.Message;
            }
        }
    }
}
