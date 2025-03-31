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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Pr2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RotateModel();
        }

        private void RotateModel()
        {
            ApplyRotation(myModel, 17, 7);
            ApplyRotation(myModel2, 34, 7);
            ApplyRotation(myModel3, 51, 7);
            ApplyRotation(myModel4, 68, 7);
            ApplyRotation(myModel5, 85, 7);
            ApplyRotation(myModel6, 102, 7);
            ApplyRotation(myModel7, 119, 7);
            ApplyRotation(myModel8, 136, 7);
            ApplyRotation(myModel9, 153, 7);
            ApplyRotation(myModel10, 170, 7);
            ApplyRotation(myModel11, 187, 7);
            ApplyRotation(myModel12, 204, 7);
            ApplyRotation(myModel13, 221, 7);
            ApplyRotation(myModel14, 238, 7);
            ApplyRotation(myModel15, 255, 7);
            ApplyRotation(myModel16, 272, 7);
            ApplyRotation(myModel17, 289, 7);
            ApplyRotation(myModel18, 306, 7);
            ApplyRotation(myModel19, 323, 7);
            ApplyRotation(myModel20, 340, 7);
            ApplyRotation(myModel21, 357, 7);
        }

        private void ApplyRotation(GeometryModel3D model, double angle, int durationSeconds)
        {
            AxisAngleRotation3D rotation = new AxisAngleRotation3D(new Vector3D(0, 0.8, 1), 0);
            RotateTransform3D rotateTransform = new RotateTransform3D(rotation);
            model.Transform = rotateTransform;

            DoubleAnimation animation = new DoubleAnimation(0, angle, new Duration(TimeSpan.FromSeconds(durationSeconds)))
            {
                FillBehavior = FillBehavior.HoldEnd // Оставляет объект в конечном положении после анимации
            };

            rotation.BeginAnimation(AxisAngleRotation3D.AngleProperty, animation);
        }
    }
}