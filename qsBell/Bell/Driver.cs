using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;


namespace qsBell.Bell
{
    class Driver
    {
        static void Main(string[] args)
        {
            Experiments.ExecGrover2Qubit(Result.Zero, 8192);

            Experiments.ExecGrover3Qubit(Result.Zero, 8192);

            Experiments.ExecGrover4Qubit(Result.Zero, 8192);

            
            /////////////////////////////////////////////////
            //Experiments.ExecPauliRZ(Result.Zero, 8192);
            // Experiments.ExecTestBellStates(Result.One);
            // Experiments.ExecMicrosoftGrover(5);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}