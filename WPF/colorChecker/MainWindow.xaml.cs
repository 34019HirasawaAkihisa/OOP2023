using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace colorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }
        List<MyColor> myColors = new List<MyColor>();

        public class colorStock {
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }


        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            Color color = Color.FromRgb((byte)sliderRed.Value, (byte)sliderGreen.Value, (byte)sliderBlue.Value);
            SolidColorBrush colo = new SolidColorBrush(color);
            colorArea.Background = colo;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var cList = GetColorList();
            var color = string.Format("R {0} G {1} B {2} ",sliderRed.Value,sliderGreen.Value,sliderBlue.Value);
            var getColor = cList.FirstOrDefault(s => s.Color == ((SolidColorBrush)colorArea.Background).Color)?.Name ?? color;
            MyColor get = new MyColor { Color = ((SolidColorBrush)colorArea.Background).Color, Name = getColor };
            myColors.Add(get);
            colorList.Items.Add(get.Name);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            {
                SolidColorBrush brush = new SolidColorBrush();
                var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
                var color = mycolor.Color;
                sliderRed.Value = color.R;
                sliderGreen.Value = color.G;
                sliderBlue.Value = color.B;

                brush.Color = mycolor.Color;
                colorArea.Background = brush;
            }
        }

        private void colorList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var cList = GetColorList();

            foreach (var item in cList) {
                if(colorList.SelectedItem.ToString() == item.Name) {
                    sliderRed.Value = item.Color.R;
                    sliderGreen.Value = item.Color.G;
                    sliderBlue.Value = item.Color.B;
                }
            }
            string[] stock = colorList.SelectedItem.ToString().Split(' ');

            if(stock.Length > 4) {
                rs.Text = stock[1];
                gs.Text = stock[3];
                bs.Text = stock[5];
            }
        }
    }
}
