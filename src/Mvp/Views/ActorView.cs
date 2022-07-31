namespace Mvp.Views
{
    public partial class ActorView : Form, IActorView
    {
        // private string searchValue = "";
        private string message = "";
        private bool isEditing;
        private bool isSuccessfully;

        public ActorView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabActors.TabPages.Remove(tabActorDetail);
            actorCloseButton.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            ActorSearchButton.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            ActorSearchTextbox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            ActorAddNewButton.Click += delegate 
            {
                AddNewActor?.Invoke(this, EventArgs.Empty); 
                tabActors.TabPages.Remove(tabActorList);
                tabActors.TabPages.Add(tabActorDetail);
                tabActorDetail.Text = "Add new actor";
            };

            ActorEditButton.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabActors.TabPages.Remove(tabActorList);
                tabActors.TabPages.Add(tabActorDetail);
                tabActorDetail.Text = "Edit actor";
            };

            ActorSaveButton.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessfully)
                {
                    tabActors.TabPages.Remove(tabActorDetail);
                    tabActors.TabPages.Add(tabActorList);
                }

                MessageBox.Show(Message);
            };

            ActorCancelButton.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabActors.TabPages.Remove(tabActorDetail);
                tabActors.TabPages.Add(tabActorList);
            };

            ActorDeleteButton.Click += delegate 
            { 
                var answer = MessageBox.Show(
                    "Are you sure you want to delete the selected actor?", 
                    "Warning", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning
                );

                if (answer == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string Id
        {
            get => ActorIdTextbox.Text;
            set => ActorIdTextbox.Text = value;
        }
        public string FullName
        {
            get => ActorNameTextbox.Text;
            set => ActorNameTextbox.Text = value;
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

        public event EventHandler? SearchEvent;
        public event EventHandler? AddNewActor;
        public event EventHandler? EditEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? SaveEvent;
        public event EventHandler? CancelEvent;

        public void SetActorListBindingSource(BindingSource actorList)
        {
            ActorGridView.DataSource = actorList;
        }

        // Singleton
        private static ActorView? instance;

        public static ActorView GetInstance(Form parentContainer)
        {
            if (instance is null || instance.IsDisposed)
            {
                instance = new ActorView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }

            return instance;
        }
    }
}
