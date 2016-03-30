using System.Web.Http;
using Scylla_TODO.Services;

namespace Scylla_TODO.Controllers
{
	[Route("todo")]
	public class ToDoController : ApiController
	{
		private readonly IToDoService _toDoService;

		public ToDoController(IToDoService todoService)
		{
			_toDoService = todoService;
		}

		[HttpGet]
		[Route("{id:int}")]
		public IHttpActionResult GetTodo(int id)
		{
			var toDo = _toDoService.GetToDoById(id);
			if (toDo != null)
			{
				return Ok(toDo);
			}
			return NotFound();
		}
	}
}