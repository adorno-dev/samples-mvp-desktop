using Mvp.Models.Repositories;
using Mvp.Models.Repositories.Contracts;
using Mvp.Views;

namespace Mvp.Presenters
{
    public class MainPresenter
    {
        private readonly string connectionString;

        private IMainView view;

        public MainPresenter(string connectionString, IMainView view)
        {
            this.connectionString = connectionString;
            this.view = view;
            this.view.ShowActorView += ShowActorView;
        }

        private void ShowActorView(object? sender, EventArgs e)
        {
            IActorView view = ActorView.GetInstance((MainView) this.view);
            IActorRepository repository = new ActorRepository(connectionString);
            new ActorPresenter(view, repository);
        }
    }
}
