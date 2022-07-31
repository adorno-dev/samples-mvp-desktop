using Mvp.Models;
using Mvp.Models.Repositories.Contracts;
using Mvp.Validators;
using Mvp.Views;

namespace Mvp.Presenters
{
    public class ActorPresenter
    {
        #region + Fields
        private IActorView view;
        private IActorRepository repository;
        private BindingSource actorsBindingSource;
        private IEnumerable<Actor>? actorList;
        #endregion

        #region + Private Methods
        private void CancelAction(object? sender, EventArgs e)
        {
            ClearViewFields();
        }

        private void SaveActor(object? sender, EventArgs e)
        {
            var actor = new Actor();
            
            actor.Id = Convert.ToInt32(view.Id);
            actor.Name = view.FullName;
            actor.Country = view.Country;
            actor.Language = view.Language;

            try
            {
                new ModelDataValidation().Validate(actor);

                if (view.IsEditing)
                {
                    repository.Edit(actor);
                    view.Message = "Actor edited successfully";
                }
                else
                {
                    repository.Add(actor);
                    view.Message = "Actor was created successfully";
                }

                view.IsSuccessfully = true;

                LoadAllActorList();
                ClearViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessfully = false;
                view.Message = ex.Message;
            }
        }

        private void ClearViewFields()
        {
            view.Id = "0";
            view.FullName = "";
            view.Country = "";
            view.Language = "";
        }

        private void DeleteSelectedActor(object? sender, EventArgs e)
        {
            try
            {
                var actor = (Actor) actorsBindingSource.Current;
                
                repository.Delete(actor.Id);

                view.IsSuccessfully = true;
                view.Message = "Actor deleted successfully.";

                LoadAllActorList();
            }
            catch
            {
                view.IsSuccessfully = false;
                view.Message = "An error ocurred, could not delete actor.";
            }
        }

        private void LoadSelectedActorToEdit(object? sender, EventArgs e)
        {
            var actor = (Actor) actorsBindingSource.Current;

            view.Id = actor.Id.ToString();
            view.FullName = actor.Name;
            view.Country = actor.Country;
            view.Language = actor.Language;
            view.IsEditing = true;
        }

        private void AddNewActor(object? sender, EventArgs e)
        {
            view.IsEditing = false;
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