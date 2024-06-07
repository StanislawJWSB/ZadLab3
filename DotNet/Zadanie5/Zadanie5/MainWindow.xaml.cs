using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SinusoidApp
{
    public partial class MainWindow : Window
    {
        private const string ApiUrl = "https://api.example.com/sinusoid"; // Placeholder URL

        public MainWindow()
        {
            InitializeComponent();
            DrawSinusoid();
        }

        private async void DrawSinusoid()
        {
            // Pobieranie danych sinusoidy z interfejsu API
            var data = await FetchSinusoidData();

            if (data != null)
            {
                // Narysowanie sinusoidy w Canva
                DrawOnCanvas(data);
            }
        }

        private async Task<double[]> FetchSinusoidData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Wysłanie żądania GET do API
                    HttpResponseMessage response = await client.GetAsync(ApiUrl);
                    response.EnsureSuccessStatusCode();

                    // // Analizowanie zawartości odpowiedzi

                    string responseBody = await response.Content.ReadAsStringAsync();

                    // API zwraca tablicę JSON z podwójnymi wartościami

                    return System.Text.Json.JsonSerializer.Deserialize<double[]>(responseBody);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
                return null;
            }
        }

        private void DrawOnCanvas(double[] data)
        {
            if (data == null || data.Length == 0) return;

            DrawCanvas.Children.Clear();

            // Utwórzenie polilini reprezentującej sinusoidę
            Polyline polyline = new Polyline
            {
                Stroke = Brushes.Blue,
                StrokeThickness = 2
            };

            // Wypełnienie punktów w polilinii
            for (int i = 0; i < data.Length; i++)
            {
                double x = i * 10; // Scale X to fit canvas
                double y = (DrawCanvas.ActualHeight / 2) - (data[i] * 100); // Scale Y to fit canvas
                polyline.Points.Add(new Point(x, y));
            }

            // Dodanie polilini do Canvas
            DrawCanvas.Children.Add(polyline);
        }
    }
}
