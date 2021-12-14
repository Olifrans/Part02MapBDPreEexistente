namespace Part02MapBDPreEexistente.Negocio
{
    public class FilmeAtor //Class Shadow Property ToTable("film_actor") dependente
    {
        public Filme Filme { get; set; } //Property de navegação -->não FK
        public Ator Ator { get; set; }  //Property de navegação -->não FK
    }
}
