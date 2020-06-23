namespace Aula23
{
    public class Cartao
    {
        public string Bandeira { get; set; }
        public float Numero { get; set; }
        public string Cvv { get; set; }
        public float Titular { get; set; }
        public string Vencimento { get; set; }

        public Cartao(){

        }
        public Cartao( string _bandeira, float _numero, string _cvv, float _titular, string _vencimento){
            this.Bandeira = _bandeira;
            this.Numero = _numero;
            this.Cvv = _cvv;
            this.Titular = _titular;
            this.Vencimento = _vencimento;
        }
    }
}