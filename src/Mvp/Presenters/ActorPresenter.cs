using Mvp.Models;
using Mvp.Models.Repositories;
using Mvp.Views;

namespace Mvp.Presenters
{
    public class ActorPresenter
    {
        #region + Fields
        private IActorView view;
        private IActorRepository repository;
        private BindingSource actorsBindingSource;
        private IEnumerable<Actor> actorList;
        #endregion

        #region + Private Methods
        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveActor(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedActor(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedActorToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewActor(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchActor(object? sender, EventArgs e)
        {
            var emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);

            actorList = (emptyValue == false) ?
                repository.GetByValue(this.view.SearchValue) :
                repository.GetAll();
                
            actorsBindingSource.DataSource = actorList;
        }
        private void LoadAllActorList()
        {
            actorList = repository.GetAll();
            actorsBindingSource.DataSource = actorList;
        }
        #endregion

        #region + Constructor
        public ActorPresenter(IActorView view, IActorRepository repository)
        {
            this.actorsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            // Subscribe event handler methods to view events
            this.view.SearchEvent += SearchActor;
            this.view.AddNewActor += AddNewActor;
            this.view.EditEvent +=  LoadSelectedActorToEdit;
            this.view.DeleteEvent += DeleteSelectedActor;
            this.view.SaveEvent += SaveActor;
            this.view.CancelEvent += CancelAction;
            // Set actors binding source
            this.view.SetActorListBindingSource(actorsBindingSource);
            // Load actor list view
            LoadAllActorList();
            // Show view
            this.view.Show();
        }
        #endregion
    }
}