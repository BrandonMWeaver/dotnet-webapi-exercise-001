using System.ComponentModel.DataAnnotations;

namespace dotnet_webapi_exercise_001.Models
{
    public class TestModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Value { get; set; }
    }
}
