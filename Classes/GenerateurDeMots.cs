namespace BlazorFindNumber.Classes
{
    internal class GenerateurDeMots
    {
        public static List<string> listeMots = new()
        { "Bible", "Torah", "Coran", "Évangile", "Psaume", "Prière", "Méditation", "Prophète", "Messie", "Croix", "Crucifixion", "Résurrection", "Baptême", "Synagogue", "Mosquée", "Temple", "Chapelet", "Salut", "Divinité", "Vierge Marie", "Saint-Esprit", "Pentecôte", "Jésus-Christ", "Krishna", "Bouddha", "Nirvana", "Réincarnation", "Karma", "Ciel", "Enfer", "Paradis", "Inferno", "Châtiment", "Création", "Créateur", "Adoration", "Foi", "Grâce", "Miséricorde", "Sacrement", "Eucharistie", "Communauté", "Monastère", "Calvaire", "Rédemption", "Vocation", "Vénération", "Litanie", "Révélation", "Anathème" };

        public static string Generer()
        {
            // Génération d'un nombre aléatoire allant de 0 à la taille de notre liste 'exclue' pour éviter les problèmes de Null
            var nombreAlea = new Random().Next(listeMots.Count);

            // On retourne l'un des mots de notre liste via utilisation de l'index obtenu aléatoirement juste au dessus
            return listeMots[nombreAlea].ToUpper();
        }
    }
}