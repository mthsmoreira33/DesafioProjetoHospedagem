namespace DesafioProjetoHospedagem.Models
{
    public class Reservation(int period)
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int Period { get; set; } = period;

        public void AddGuests(List<Person> guests)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacity > guests.Count)
            {
                Guests = guests;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new ApplicationException("Capacidade menor que o número de hospedes");

            }
        }

        public void AddSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetTotalGuests()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Guests.Count;
        }

        public decimal CalculateDailyRate()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: Period X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal rate = Period * Suite.DailyRate;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (Period >= 10)
            {
                rate -= rate * 0.10m;
            }

            return rate;
        }
    }
}