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
using RestSharp;
using Newtonsoft.Json;


namespace RealTimeTranslator
{
    public partial class MainWindow : Window
    {
        private const string ApiKey = "AIzaSyAHNPpIpgbnspEIwMPSeMGY8a0E0mSEggQ";
        private const string TranslateApiUrl = "https://translation.googleapis.com/language/translate/v2";

        public MainWindow()
        {
            InitializeComponent();
            LoadLanguages();
        }

        private void LoadLanguages()
        {
            
            SourceLanguage.Items.Add("en"); 
            SourceLanguage.Items.Add("es"); 
            SourceLanguage.Items.Add("fr"); 
            SourceLanguage.Items.Add("de"); 
            SourceLanguage.Items.Add("zh");
            SourceLanguage.Items.Add("af");
            SourceLanguage.Items.Add("hi");

            TargetLanguage.Items.Add("en"); // English
            TargetLanguage.Items.Add("es"); // Spanish
            TargetLanguage.Items.Add("fr"); // French
            TargetLanguage.Items.Add("de"); // German
            TargetLanguage.Items.Add("zh"); // Chinese
            TargetLanguage.Items.Add("af"); // Afrikaans
            TargetLanguage.Items.Add("hi"); // Hindi

            SourceLanguage.SelectedIndex = 0;
            TargetLanguage.SelectedIndex = 1;
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            var client = new RestClient(TranslateApiUrl);
            var request = new RestRequest();

            request.Method = Method.Post;

            request.AddParameter("key", ApiKey);
            request.AddParameter("q", InputText.Text);
            request.AddParameter("source", SourceLanguage.SelectedItem.ToString());
            request.AddParameter("target", TargetLanguage.SelectedItem.ToString());

            var response = client.Execute(request);

            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);

            if (jsonResponse != null && jsonResponse.data != null && jsonResponse.data.translations != null)
            {
                TranslatedText.Text = jsonResponse.data.translations[0].translatedText;
            }
            else
            {
                TranslatedText.Text = "Translation failed.";
            }
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(TranslatedText.Text);
        }
    }
}
