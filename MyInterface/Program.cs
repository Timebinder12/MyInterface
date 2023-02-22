using System;

namespace MyInterface
{
    interface IComputer
    {
        string processor { get; set; }
        string motherboard { get; set; }
        string powerSupply { get; set; }
        void Describe();
    }
    class Program
    {
        class GamingComputer : IComputer
        {
            public string processor { get; set; }
            public string motherboard { get; set; }
            public string powerSupply { get; set; }
            public string graphicsCard { get; set; }
            public string cooler { get; set; }
            public GamingComputer()
            {
                processor= string.Empty;
                cooler= string.Empty;
                motherboard= string.Empty;
                powerSupply= string.Empty;
                graphicsCard = string.Empty;
            }
            public GamingComputer(string processor, string motherboard, string powerSupply, string graphicsCard, string cooler)
            {
                this.processor= processor;
                this.motherboard= motherboard;
                this.powerSupply= powerSupply;
                this.graphicsCard= graphicsCard;
                this.cooler= cooler;
            }
            public void Describe()
            {
                Console.WriteLine("Here are the specs of the computer:");
                Console.WriteLine($"Proccessor: {processor}");
                Console.WriteLine($"Motherboard: {motherboard}");
                Console.WriteLine($"Power Supply: {powerSupply}");
                Console.WriteLine($"Graphics Card: {graphicsCard}");
                Console.WriteLine($"CPU Cooler: {cooler}");
            }
        }
        static void Main(string[] args)
        {
            GamingComputer shanesComputerSpecs= new GamingComputer("12th Generation Intel Core I5 - 12600k", "MSI PRO Z690 Edge", "Corsair 650 Watt", "AMD Radeon RX 6600","Corsair Water Cooling" );
            shanesComputerSpecs.Describe();
        }
    }
}