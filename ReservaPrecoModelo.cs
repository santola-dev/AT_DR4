namespace AT.Delegates_Eventos
{
    public class ReservaPrecoModelo
    {
        public int QuantidadePessoas { get; set; }
        public decimal PrecoPorPessoa { get; set; }
        public decimal ValorTotal { get; set; }

        public void Calcular()
        {
            ValorTotal = QuantidadePessoas * PrecoPorPessoa;
        }
    }
}

