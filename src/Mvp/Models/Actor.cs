using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mvp.Models
{
    public class Actor
    {
        private int id;
        private string name;
        private string country;
        private string language;

        [DisplayName("Actor Code")]
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }

        [DisplayName("Actor Name")]
        [Required(ErrorMessage = "Actor name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Actor name must be between 3 and 50 characters.")]
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }


        [DisplayName("Actor Country")]
        [Required(ErrorMessage = "Actor country is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Actor country must be between 3 and 50 characters.")]
        public string Country 
        { 
            get => country; 
            set => country = value; 
        }

        [DisplayName("Actor Language(s)")]
        [Required(ErrorMessage = "Actor name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Actor language must be between 3 and 50 characters.")]
        public string Language 
        { 
            get => language; 
            set => language = value; 
        }
    }
}
