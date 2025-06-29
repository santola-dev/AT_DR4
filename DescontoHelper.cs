namespace AT.Delegates_Eventos
{
    public delegate decimal CalculateDelegate(decimal precoOriginal);

    public static class DescontoHelper
    {
        public static decimal AplicarDesconto(decimal preco)
        {
            return preco * 0.9m;
        }
    }
}

