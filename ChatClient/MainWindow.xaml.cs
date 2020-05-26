using ChatInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using WebCam_Capture;

namespace ChatClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static IChatServices Server;
        private static DuplexChannelFactory<IChatServices> _channelFactory;
        WebCam webcam;
        public  MainWindow()
        {
            InitializeComponent();
            _channelFactory = new DuplexChannelFactory<IChatServices>(new ClientCallback(), "ChatServiceEndPoint");
            Server = _channelFactory.CreateChannel();
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
        }

        public void takeMessages(string message, string userName)
        {
            mesazhet.Text += userName + ": " + message + "\n";

        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            Server.SendMessageToAll(mesazhi.Text, usernameBox.Text);
            takeMessages(mesazhi.Text, usernameBox.Text);
            mesazhi.Text = "";
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            int retur = Server.Login(usernameBox.Text);
            if(retur == 1)
            {
                MessageBox.Show("Je Logged");
                
            }
            else
            {
                MessageBox.Show("Hyt ne chat me sukses");
                usernameBox.IsEnabled = false;
                login.IsEnabled = false;
                label1.Content = usernameBox.Text;

                LoadUserList(Server.GetCurrentUsers());
                
            }

            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Server.logout();
        }
        public void AddUserToList(string username)
        {
            if (!usersListBox.Items.Contains(username))
            {
                usersListBox.Items.Add(username);
            }
            
        }

        public void removeUserFromList(string username)
        {
            if (usersListBox.Items.Contains(username))
            {
                usersListBox.Items.Remove(username);
            }
        }
        private void LoadUserList(List<string> users)
        {
            foreach(var user in users)
            {
                AddUserToList(user);
            }
        }

        private void bntStart_Click(object sender, RoutedEventArgs e)
        {
            webcam.Start();
        }

        private void bntStop_Click(object sender, RoutedEventArgs e)
        {
            webcam.Stop();
        }

        private void bntContinue_Click(object sender, RoutedEventArgs e)
        {
            webcam.Continue();
        }

        private void bntCapture_Click(object sender, RoutedEventArgs e)
        {
            /*WebCam wc = new WebCam();*/
            imgCapture.Source = imgVideo.Source;
            /*usersListBox.Items.Add(new WebCamCapture.WebCamEventHandler(wc.webcam_ImageCaptured(sender,e)));*/
        }

        private void bntSaveImage_Click(object sender, RoutedEventArgs e)
        {
            Helper.SaveImageCapture((BitmapSource)imgCapture.Source);
        }

        private void bntResolution_Click(object sender, RoutedEventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void bntSetting_Click(object sender, RoutedEventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void usersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
