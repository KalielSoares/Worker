using Worker.Entities.Enums;

namespace Worker.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double baseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts = new List<HourContract>();

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
    }
}
