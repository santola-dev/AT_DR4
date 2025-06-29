namespace AT.Delegates_Eventos;

public class PacoteTuristico
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public DateTime DataInicio { get; set; }
    public int CapacidadeMaxima { get; set; }
    public decimal Preco { get; set; }
    public List<Destino> Destinos { get; set; } = new();
    public List<Reserva> Reservas { get; set; } = new();


    public event Action<PacoteTuristico> CapacityReached;

    public void AdicionarReserva(Reserva reserva)
    {
        Reservas.Add(reserva);

        if (Reservas.Count > CapacidadeMaxima)
        {
            CapacityReached?.Invoke(this);
        }
    }
}
