using System.ComponentModel.DataAnnotations;

namespace HelloABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}