using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;


namespace qsBell.Bell
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Experiments.ExecGrover2Qubit(Result.One);
            Experiments.ExecGrover2Qubit2(Result.Zero, 8192);

            // Experiments.ExecGrover3Qubit(Result.One);
            Experiments.ExecGrover3Qubit2(Result.Zero, 8192);

            //Experiments.ExecGrover4Qubit(Result.One);
            //Experiments.ExecGrover4Qubit2(Result.Zero, 8192);

            
            /////////////////////////////////////////////////
            //Experiments.ExecPauliRZ(Result.Zero, 8192);
            // Experiments.ExecTestBellStates(Result.One);
            // Experiments.ExecMicrosoftGrover(5);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}