namespace ElasticSearch.Poc
{
    internal class Personne
    {
        public int Id { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Nom
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Adresse
        /// </summary>
        public string Adresse { get; set; }
        /// <summary>
        /// Code Postal
        /// </summary>
        public string CodePostal { get; set; }

        public string Ville { get; set; }
    }
}