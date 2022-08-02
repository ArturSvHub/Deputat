using System.ComponentModel.DataAnnotations;

namespace Shultc.Data.Form
{
	public class ReceptionForm
	{
		[Required(ErrorMessage = "Напишите, пожалуйста, своё имя")]
		[StringLength(10, ErrorMessage = "Имя слишком длинное")]
		public string? Name { get; set; }
		[Required(ErrorMessage = "Введите свой Email адрес")]
		public string? Email { get; set; }
		[Required(ErrorMessage = "Выберите тему обращения")]
		public string? Subject { get; set; }
		
		public bool IsAgreeWithContract { get; set; }
		[Required(ErrorMessage = "Сообщение пусто")]
		public string? Message { get; set; }
		public DateTime SendMessageDate { get; set; }

	}
}
