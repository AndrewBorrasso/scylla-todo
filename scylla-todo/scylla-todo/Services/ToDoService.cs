using Scylla_TODO.DTOs;

namespace Scylla_TODO.Services
{
	public class ToDoService : IToDoService
	{
		public ToDo GetToDoById(int id)
		{
			return new ToDo(id);
		}
	}
}