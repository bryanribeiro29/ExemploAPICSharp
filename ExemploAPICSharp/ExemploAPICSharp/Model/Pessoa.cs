namespace ExemploAPICSharp.Model
{
    public class Pessoa
    {
        //prop e Tab = propriedade (exatamente a de baixo).
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumeroCelular { get; set;}
        public DateOnly DataNascimento { get; set; }
    }
    
}
