namespace Mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            actorsButton.Click += delegate { ShowActorView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowActorView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowMovieView;
    }
}
