/*
 * Ian McTavish
 * March 21, 2018
 * u2LoopReview
 * User types integers, uses -1 to indicate the end of the loop
 * The average is output
 */
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

namespace usLoopReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global variables go here
        int x;
        public MainWindow()
        {
            InitializeComponent();
            x = 3;
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            string textEntered = txtInput.Text;

            MessageBox.Show(textEntered);
            int positionOfSlashR = textEntered.IndexOf("\r");
            MessageBox.Show(textEntered.IndexOf("\r").ToString());
            string tempNumber = textEntered.Substring(0, positionOfSlashR);
            MessageBox.Show(tempNumber);
            int total = 0;
            int counter = 0;
            int numberEntered = 0;
            int.TryParse(tempNumber, out numberEntered);
            while (numberEntered != -1)
            {
                total = total + numberEntered;
                counter++;//short for add one to counter
                int previousPositionOfR = positionOfSlashR;
                positionOfSlashR = textEntered.IndexOf("\r", positionOfSlashR + 1);
                tempNumber = textEntered.Substring(previousPositionOfR+2, positionOfSlashR-previousPositionOfR-2);
                int.TryParse(tempNumber, out numberEntered);
                MessageBox.Show("In loop total is: " + total.ToString());
            }
            MessageBox.Show("Out of loop, total is: " + total.ToString());
            MessageBox.Show("Average is: " + (total / counter).ToString())
;        }
    }
}
