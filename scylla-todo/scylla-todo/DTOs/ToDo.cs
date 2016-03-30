namespace Scylla_TODO.DTOs
{
	public class ToDo
	{
		public int Id { get; private set; }
		public string Description { get; set; }

		public ToDo()
		{
			Id = 0;
		}

		public ToDo(int id)
		{
			Id = id;
		}
	}
}