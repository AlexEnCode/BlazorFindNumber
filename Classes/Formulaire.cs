using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorFindNumber.Classes
{
    public class Formulaire
    {
        /*[Key]
        [Column("(id)")]
        public int Id { get; set; }*/

        [Column("prenom")]
        [Required(ErrorMessage = "Le prénom est requis.")]
        public string Prenom { get; set; }

        [Column("nom")]
        [Required(ErrorMessage = "Le nom est requis.")]
        public string Nom { get; set; }

        [RegularExpression(@"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-_]+)(\.)?([a-zA-Z0-9\-_]+)?(\.){1}([a-zA-Z]{2,11})$", ErrorMessage = "Adresse email invalide.")]
        [Required(ErrorMessage = "L'email est requis.")]
        [Column("email")]
        public string Email { get; set; }

        [Column("DateDeNaissance")]
        [Required(ErrorMessage = "La date de naissance est requise.")]
        public DateTime DateDeNaissance { get; set; }

        [Column("adresse")]
        [Required(ErrorMessage = "L'adresse est requise.")]
        public string Adresse { get; set; }

        [Column("CodePostale")]
        [Required(ErrorMessage = "Le code postal est requis.")]
        public int CodePostale { get; set; }

		[Column("Married")]
		[Required(ErrorMessage = "Le Married est requis.")]
		public bool Married { get; set; }


		[Column("Color")]
        [Required(ErrorMessage = "La couleur est requisz.")]
        public Color FavoriteColor { get; set; }

    }

    public enum Color
    {
		Nothing,
		 Bleu,
        BleuFoncé,
        BleuClair,
        BleuMarine
             
    }
}
