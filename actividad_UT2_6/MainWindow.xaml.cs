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

namespace actividad_UT2_6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            episodioIVImage.MouseEnter += MouseEnterImages;
            episodioVImage.MouseEnter += MouseEnterImages;
            episodioVIImage.MouseEnter += MouseEnterImages;
        }

        private void MouseEnterImages(object sender, MouseEventArgs args)
        {
            if (sender == episodioVImage) episodioVImage.Opacity = 1;
            if  (sender == episodioIVImage) episodioIVImage.Opacity = 1;
            if (sender == episodioVIImage) episodioVIImage.Opacity = 1;


            /*Image imagen = (Image)sender;
            imagen.Opacity = 1;*/

        }
        private void MouseLeaveImages(object sender, MouseEventArgs args)
        {
            if (sender != episodioVImage) episodioVImage.Opacity = 0.5;
            if (sender != episodioIVImage) episodioIVImage.Opacity = 0.5;
            if (sender != episodioVIImage) episodioVIImage.Opacity = 0.5;

        }
    }
}
