using System;
using Scylla_TODO.Entities;

namespace Scylla_TODO.Repositories
{
	public interface IToDoRepository
	{
		ToDo GetToDoById(int id);
	}
}