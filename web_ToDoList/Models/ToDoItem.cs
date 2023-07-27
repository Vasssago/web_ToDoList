using web_ToDoList.Areas.Identity.Data;

namespace web_ToDoList.Models
{
	public class ToDoItem
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public bool IsDone { get; set; }
		public DateTime DueDate { get; set; } // Дата выполнения задачи
		public virtual ApplicationUser User { get; set; }
	}
}
