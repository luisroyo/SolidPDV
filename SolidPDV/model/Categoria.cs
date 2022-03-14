namespace SolidPDV
{
    public class Categoria
    {
        public int id;
        public string nome;

        public Categoria(string nome)
        {
            this.nome = nome;
        }

        public Categoria() { }

        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
    }

}
