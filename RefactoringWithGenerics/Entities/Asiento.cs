namespace RefactoringWithGenerics.Entities
{
    public class Asiento
    {
        public int AsientoId { get; set; }
        public int BusId { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }

        public override string ToString()
        {
            return $" Las propiedades son: AsientoId: {AsientoId}, BusId: {BusId}, NumeroPiso: {NumeroPiso}, NumeroAsiento: {NumeroAsiento}, FechaCreacion: {FechaCreacion}";
        }
    }
}
