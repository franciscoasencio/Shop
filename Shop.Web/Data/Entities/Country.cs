namespace Shop.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Country : IEntity
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "The field {0} can only contain a maximum of {1} characters")]
        [Required]
        public string Name { get; set; }

    }
}
