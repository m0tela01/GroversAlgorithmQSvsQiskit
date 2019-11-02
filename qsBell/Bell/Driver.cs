using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;


namespace qsBell.Bell
{
    class Driver
    {
        static void Main(string[] args)
        {

            Experiments.ExecTestBellStates(Result.One);

            Experiments.ExecGrover2Qubit(Result.One);
            
            Experiments.ExecGrover3Qubit(Result.One);

            Experiments.ExecGrover4Qubit(Result.One);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}