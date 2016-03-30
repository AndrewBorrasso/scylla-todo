using Scylla_TODO.Entities;

namespace Scylla_TODO.Config
{
	public class Mappings : Cassandra.Mapping.Mappings
	{
		public Mappings()
		{
			For<ToDo>()
				.TableName("todos")
				.PartitionKey(todo => todo.Id)
				.Column(todo => todo.Id)
				.Column(todo => todo.Description)
				.Column(todo => todo.IsDone);
		}
	}
}