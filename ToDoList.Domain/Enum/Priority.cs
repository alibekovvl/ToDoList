using System.ComponentModel.DataAnnotations;

/// <summary>
/// Приоритет задачи 
/// </summary>
namespace ToDoList.Domain.Enum
{
    public  enum Priority
    {
        [Display(Name = "Простая")]
        Easy = 0,
        [Display(Name = "Важная")]
        Medium = 1,
        [Display(Name = "Критичная")]
        High = 2
    }
}
