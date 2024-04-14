using System.ComponentModel.DataAnnotations;

namespace BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
