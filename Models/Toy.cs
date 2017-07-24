using System.ComponentModel.DataAnnotations;

namespace BagAPI.Models
{
    public class Toy
    {
        [Key]
        public int ToyId {get; set;}

        [Required]
        public string Name {get; set;}


        //Establish relationship 

        public int ChildId {get; set;}

        public Child Child {get; set;}

    }
}