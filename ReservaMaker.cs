namespace AT.Delegates_Eventos
{
    public class Reserva
    {
        public Cliente Cliente { get; set; }
        public int PacoteTuristicoId { get; set; }
        public PacoteTuristico PacoteTuristico { get; set; }
        public DateTime DataReserva { get; set; }
    }
}
