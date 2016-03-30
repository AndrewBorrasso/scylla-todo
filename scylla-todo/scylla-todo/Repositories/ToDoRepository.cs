using Cassandra;
using Cassandra.Data.Linq;
using Scylla_TODO.Entities;

namespace Scylla_TODO.Repositories
{
	public class ToDoRepository : IToDoRepository
	{
		private readonly ISession _session;

		public ToDoRepository(ISession session)
		{
			_session = session;
		}

		public ToDo GetToDoById(int id)
		{
			var todos = new Table<ToDo>(_session);
			return todos.FirstOrDefault(todo => todo.Id == id).Execute();
		}
	}
}