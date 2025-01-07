
using DesafioProjetoHospedagem.Models;
using System.Globalization;

Person guest1 = new("João", "Silva");
Suite suite = new("Presidencial", 4, 1000);
List<Person> guests = [guest1];

Reservation reservation = new(5);
reservation.AddSuite(suite);
reservation.AddGuests(guests);

Console.WriteLine(
    $"Total de Hóspedes: {reservation.GetTotalGuests()} Pessoas\n" +
    $"Capacidade da Suíte: {reservation.Suite.Capacity} Pessoas\n" +
    $"Quantidade de Dias: {reservation.Period} Dias\n" +
    $"Preço Total: {reservation.CalculateDailyRate().ToString("C", new CultureInfo("pt-BR"))}");

Console.WriteLine("Hóspedes: ");

foreach (var guest in reservation.Guests)
{
    Console.WriteLine(guest.FullName);
}

