using System;
using System.Diagnostics;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace qsBell.Bell
{
    public static class Experiments
    {
        public static Stopwatch stopwatch;

        /// Grover 2 Qubit set initial states of all qubits to Result.Zero or Result.One, default shots = 1024
        public static void ExecGrover2Qubit(Result initialState, int shots = 1024)
        {
            stopwatch = new Stopwatch();
            Helper.Print("Grover 2 Qubits: ");
            Helper.StartTime(stopwatch);
            using (QuantumSimulator qsim = new QuantumSimulator())
            {
                var res = Grover2Qubit.Run(qsim, shots, initialState).Result;
                for (int i = 0; i < res.Count; i++)
                {
                    Console.WriteLine(Int32.Parse(Convert.ToString(i, 2)).ToString("00") + ": " + res[long.Parse(i.ToString())]);
                }
            }
            Helper.OperationTime(stopwatch);
        }
        
        /// Grover 3 Qubit set initial states of all qubits to Result.Zero or Result.One, default shots = 1024
        public static void ExecGrover3Qubit(Result initialState, int shots = 1024)
        {
            stopwatch = new Stopwatch();
            Helper.Print("Grover 3 Qubits: ");
            Helper.StartTime(stopwatch);
            using (QuantumSimulator qsim = new QuantumSimulator())
            {
                var res = Grover3Qubit.Run(qsim, shots, initialState).Result;
                for (int i = 0; i < res.Count; i++)
                {
                    Console.WriteLine(Int32.Parse(Convert.ToString(i, 2)).ToString("000") + ": " + res[long.Parse(i.ToString())]);
                }
            }
            Helper.OperationTime(stopwatch);
        }
        /// Grover 4 Qubit set initial states of all qubits to Result.Zero or Result.One, default shots = 1024
        public static void ExecGrover4Qubit(Result initialState, int shots = 1024)
        {
            stopwatch = new Stopwatch();
            Helper.Print("Grover 4 Qubits: ");
            Helper.StartTime(stopwatch);
            using (QuantumSimulator qsim = new QuantumSimulator())
            {
                var res = Grover4Qubit.Run(qsim, shots, initialState).Result;
                for (int i = 0; i < res.Count; i++)
                {
                    Console.WriteLine(Int32.Parse(Convert.ToString(i, 2)).ToString("0000") + ": " + res[long.Parse(i.ToString())]);
                }
            }
            Helper.OperationTime(stopwatch);
        }
        
        
        ////////////////// /////////////////
        public static void ExecTestBellStates(Result initialState, int shots = 1024)
        {
            Helper.Print("Test Bell State");
            using (var qsim = new QuantumSimulator())
            {
                var res = TestBellState.Run(qsim, shots, initialState).Result;
                var (numZeros, numOnes, agree) = res;
                Console.WriteLine(
                    $"Init: {initialState , -4} 0s = {numZeros, -4} 1s = {numOnes, -4}  agrees = {agree, -4}"
                );
                Console.WriteLine();
            }
        }
        public static void ExecMicrosoftGrover(int numberOfQubits)
        {
            Helper.Print("Microsoft Grover with: " + numberOfQubits.ToString() + " Qubits");
            using(var qsim = new QuantumSimulator())
            {
                var res = SearchForMarkedInput.Run(qsim, numberOfQubits).Result;
                Console.WriteLine($"Result: {res}\n");
            }
        }
        /// Test 1 Qubit R gate as U gate in Q# vs qiskit set initial states of all qubits to Result.Zero or Result.One, default shots = 1024
        public static void ExecPauliRZ(Result initialState, int shots = 1024)
        {
            Helper.Print("Test Pauli Z: 1 Qubit");
            using (var qsim = new QuantumSimulator())
            {
                var res = TestPaulRZ.Run(qsim, shots, initialState).Result;
                var (num_zeros_q0, num_ones_q0) = res;
                Console.WriteLine(
                    $"Init: {initialState, -4} 0sq0 = {num_zeros_q0, -4} 1sq0 = {num_ones_q0, -4}  1sq0"
                );                
                Console.WriteLine();
            }
        }
    }
}