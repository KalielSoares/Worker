using System.Diagnostics.Contracts;

namespace Worker.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHNour { get; set; }
        public int Hours { get; set; }


        public double totalValue()
        {
            return ValuePerHNour * Hours;
        }
    }
}
