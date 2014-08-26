using Windows.UI.Xaml.Media.Imaging;

namespace CarVoter.Model
{
    public class Car
    {
        public BitmapImage Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Kilowatts { get; set; }
        public int NumUpVotes { get; set; }
        public int NumDownVotes { get; set; }
    }
}
