namespace Mvp.Views
{
    public partial class ActorView : Form, IActorView
    {
        private string searchValue;
        private string message;
        private bool isEditing;
        private bool isSuccessfully;

        public ActorView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabActors.TabPages.Remove(tabActorDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            ActorSearchButton.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            ActorSearchTextbox.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public string Id 
        { 
            get => ActorIdTextbox.Text; 
            set => ActorIdTextbox.Text = value;
         }
        public string Country 
        { 
            get => ActorCountryTextbox.Text; 
            set => ActorCountryTextbox.Text = value;
         }
        public string Language 
        { 
            get => ActorLanguageTextbox.Text; 
            set => ActorLanguageTextbox.Text = value;
         }
        public string SearchValue 
        { 
            get => ActorSearchTextbox.Text; 
            set => ActorSearchTextbox.Text = value;
         }
        public string Message 
        { 
            get => message; 
            set => message = value;
         }
        public bool IsEditing 
        { 
            get => isEditing; 
            set => isEditing = value;
         }
        public bool IsSuccessfully 
        { 
            get => isSuccessfully; 
            set => isSuccessfully = value;
         }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewActor;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetActorListBindingSource(BindingSource actorList)
        {
            ActorGridView.DataSource = actorList;
        }
    }
}
