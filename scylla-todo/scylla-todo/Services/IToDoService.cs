using Scylla_TODO.DTOs;

namespace Scylla_TODO.Services
{
	public interface IToDoService
	{
		ToDo GetToDoById(int id);
	}
}