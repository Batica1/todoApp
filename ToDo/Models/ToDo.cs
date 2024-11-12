using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the description...")]
        public string Description { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please enter the due date")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please select the category")]
        public string CategoryId { get; set; } = string.Empty;

        [ValidateNever]
        public Category Category { get; set; } = null;

        [Required(ErrorMessage = "Please select the status")]
        public string StatusId { get; set; } = string.Empty;

        [ValidateNever]
        public Status Status { get; set; } = null;

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Now;



    }
}
