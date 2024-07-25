using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static Number_Word.Converter;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Number_Word
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        int word;
        private void btn01_Click(object sender, RoutedEventArgs e)
        {   
            //textblock01.Text = Converter.Convert(int.Parse(textbox1.Text));
            if (textbox1.Text == "")
            {
                textblock_02.Text = "NOTE: PLEASE ENTER A WHOLE NUMBER!";
            }
            else
            {
                word = int.Parse(textbox1.Text);
                textbox6.Text = Converter.Convert(int.Parse(textbox1.Text));
                textblock_02.Text = "";

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "")
            {
                textblock_02.Text = "NOTE: PLEASE ENTER A WHOLE NUMBER!";
            }
            else
            {
                textblock_02.Text = "";
                textbox1.Text = "";
                textbox6.Text = "";
            }
        }
    }
}
