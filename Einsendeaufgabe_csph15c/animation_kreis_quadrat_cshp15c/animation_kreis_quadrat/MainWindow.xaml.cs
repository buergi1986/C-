using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace animation_kreis_quadrat
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int seconds;

        private int geschwindigkeit()
        {
            if (sliderGeschwindigkeit.Value > 1)
                seconds = Convert.ToInt32(sliderGeschwindigkeit.Value);
            else
                seconds = 1;
            return seconds;
        }

        public MainWindow()
        {
            InitializeComponent();
            textblockQuadrat.Text = sliderQuadrat.Value.ToString();
            textblockKreis.Text = sliderKreis.Value.ToString();
            textblockGeschwindigkeit.Text = sliderGeschwindigkeit.Value.ToString();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {

            DoubleAnimation kreisAnimation = new DoubleAnimation();

            DoubleAnimation quadratAnimation = new DoubleAnimation();

            try
            {
                kreisAnimation.From = kreis.Width;
                kreisAnimation.To = kreis.Width * 4;
                kreisAnimation.Duration = TimeSpan.FromSeconds(geschwindigkeit());
                kreisAnimation.AutoReverse = true;
                kreisAnimation.RepeatBehavior = new RepeatBehavior(10);

                quadratAnimation.From = quadrat.Width;
                quadratAnimation.To = quadrat.Width / 4;
                quadratAnimation.Duration = TimeSpan.FromSeconds(geschwindigkeit());
                quadratAnimation.AutoReverse = true;
                quadratAnimation.RepeatBehavior = new RepeatBehavior(10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Das ist ein Problem", ex.Message);
            }
            finally
            {
                kreis.BeginAnimation(WidthProperty, kreisAnimation);
                quadrat.BeginAnimation(WidthProperty, quadratAnimation);
                kreis.BeginAnimation(HeightProperty, kreisAnimation);
                quadrat.BeginAnimation(HeightProperty, quadratAnimation);
            }
        }

        private void buttonBeenden_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void sliderQuadrat_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(quadrat != null)
            {
                quadrat.Width = quadrat.Height = e.NewValue;
                textblockQuadrat.Text = e.NewValue.ToString();
            }
            else
                return;
        }

        private void sliderKreis_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(kreis != null)
            {
                kreis.Width = kreis.Height = e.NewValue;
                textblockKreis.Text = e.NewValue.ToString();
            }
            else
                return;
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void sliderGeschwindigkeit_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(textblockGeschwindigkeit != null)
            {
                textblockGeschwindigkeit.Text = sliderGeschwindigkeit.Value.ToString();
            }
        }
    }
}
