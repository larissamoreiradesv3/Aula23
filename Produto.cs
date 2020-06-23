namespace Aula23
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public  float Codigo { get; set; }

        public Produto(){

        }
        public Produto( string _nome, int _numero, float _codigo ){
            this.Nome = _nome;
            this.Numero = _numero;
            this.Codigo = _codigo;        }
    }
}