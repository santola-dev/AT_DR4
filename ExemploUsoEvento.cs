namespace AT.Delegates_Eventos;

using System;

public class ExemploUsoEvento
{
    public void Testar()
    {
        var pacote = new PacoteTuristico
        {
            Titulo = "Pacote para Gramado",
            CapacidadeMaxima = 2
        };

        pacote.CapacityReached += RegistrarNoConsole;

        pacote.AdicionarReserva(new Reserva());
        pacote.AdicionarReserva(new Reserva());
        pacote.AdicionarReserva(new Reserva());
    }

    private void RegistrarNoConsole(PacoteTuristico pacote)
    {
        Console.WriteLine($"[ALERTA] Capacidade excedida no pacote: {pacote.Titulo}");
    }
}
