using System.Data;
using System.Data.SqlClient;
using Mvp.Models.Repositories.Contracts;

namespace Mvp.Models.Repositories
{
    public class ActorRepository : BaseRepository, IActorRepository
    {
        public ActorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(Actor model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Actor model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetAll()
        {
            var actorList = new List<Actor>();
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand();

            connection.Open();
            command.CommandText = "SELECT * FROM Actors ORDER BY Id DESC";
            command.Connection = connection;

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var actor = new Actor();
                    actor.Id = reader.GetFieldValue<int>(0);
                    actor.Name = reader.GetFieldValue<string>(1);
                    actor.Country = reader.GetFieldValue<string>(2);
                    actor.Language = reader.GetFieldValue<string>(3);
                    actorList.Add(actor);
                }
            }

            return actorList;
        }

        public IEnumerable<Actor> GetByValue(string value)
        {
            var actorId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            var actorName = value;

            var actorList = new List<Actor>();
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand();

            connection.Open();
            command.CommandText = @"SELECT * FROM Actors WHERE Id=@id OR Name LIKE @name+'%' ORDER BY Id DESC";
            command.Parameters.Add("@id", SqlDbType.Int).Value = actorId;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = actorName;
            command.Connection = connection;

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var actor = new Actor();
                    actor.Id = reader.GetFieldValue<int>(0);
                    actor.Name = reader.GetFieldValue<string>(1);
                    actor.Country = reader.GetFieldValue<string>(2);
                    actor.Language = reader.GetFieldValue<string>(3);
                    actorList.Add(actor);
                }
            }

            return actorList;
        }
    }
}