namespace Mvp.Views
{
    public interface IActorView
    {
        string Id { get; set; }
        string FullName { get; set; }
        string Country { get; set; }
        string Language { get; set; }

        string SearchValue { get; set; }
        string Message { get; set; }
        bool IsEditing { get; set; }
        bool IsSuccessfully { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewActor;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetActorListBindingSource(BindingSource actorList);
        void Show();
    }
}
