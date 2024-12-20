using System.ComponentModel.DataAnnotations;

namespace ATA.Bluebook.Web.Models
{
    public class ComponentTabModel
    {
        public int id { get; set; }
        public string text { get; set; } = default!;

        public ComponentTabModel() { }
        public ComponentTabModel(int _id, string name)
        {
            id = _id;
            text = name;
        }
    }

    public class GenderSelectionModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class SelectionBoxModel
    {
        [Display(Name = "Gender")]
        public int GenderId { get; set; }
    }

    public class DateBoxModel
    {
        [Display(Name = "Birth Date")]
        public DateTime? Birthdate { get; set; } = null;
    }

    public class TextBoxModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
