using System.ComponentModel.DataAnnotations;

namespace evitoriav2.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}