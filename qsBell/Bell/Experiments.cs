using System;
using System.Diagnostics;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace qsBell.Bell
{
    public static class Experiments
    {
        public static Stopwatch stopwatch;

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

        /// Grover 2 Qubit set initial states of all qubits to Result.Zero or Result.One, default shots = 1024
        public static void ExecGrover2Qubit(Result initialState, int shots = 1024)
        {
            Helper.Print("Grover 2 Qubit");
            using (var qsim = new QuantumSimulator())
            {
                var res = Grover2Qubit.Run(qsim, shots, initialState).Result;
                var (num_zeros_q0, num_zeros_q1, num_ones_q0, num_ones_q1, agree_q0, agree_q1) = res;
                Console.WriteLine(
                    $"Init: {initialState, -4} 0sq0 = {num_zeros_q0, -4} 0sq1 = {num_zeros_q1, -4}  1sq0 = {num_ones_q0, -4}    1sq1 = {num_ones_q1, -4}    agree0 = {agree_q0, -4}    agree1 = {agree_q1, -4}"
                );                
                Console.WriteLine();
            }
        }

        public static void ExecGrover2Qubit2(Result initialState, int shots = 1024)
        {
            stopwatch = new Stopwatch();
            Helper.Print("Grover 2 Qubits: ");
            Helper.StartTime(stopwatch);
            using (QuantumSimulator qsim = new QuantumSimulator())
            {
                var res = Grover2Qubit2.Run(qsim, shots, initialState).Result;
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
            Console.WriteLine("Grover 3 Qubit");
            using (var qsim = new QuantumSimulator())
            {
                var res = Grover3Qubit.Run(qsim, shots, initialState).Result;
                var (num_zeros_q0, num_zeros_q1, num_zeros_q2, num_ones_q0, num_ones_q1, num_ones_q2, agree_q0, agree_q1, agree_q2) = res;
                Console.WriteLine(
                    $"Init: {initialState, -4}    0sq0 = {num_zeros_q0, -4}    0sq1 = {num_zeros_q1, -4}    0sq2={num_zeros_q2, -4}    1sq0 = {num_ones_q0, -4}    1sq1 = {num_ones_q1, -4}    1sq2={num_ones_q2, -4}    agree0 = {agree_q0, -4}    agree1 = {agree_q1, -4}    agree2={agree_q2, -4}"
                );
                Console.WriteLine();
            }
        }

        public static void ExecGrover3Qubit2(Result initialState, int shots = 1024)
        {
            stopwatch = new Stopwatch();
            Helper.Print("Grover 3 Qubits: ");
            Helper.StartTime(stopwatch);
            using (QuantumSimulator qsim = new QuantumSimulator())
            {
                var res = Grover3Qubit2.Run(qsim, shots, initialState).Result;
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
            Console.WriteLine("Grover 4 Qubit");
            using (var qsim = new QuantumSimulator())
            {
                var res = Grover4Qubit.Run(qsim, shots, initialState).Result;
                var (num_zeros_q0, num_zeros_q1, num_zeros_q2, num_zeros_q3, num_ones_q0, num_ones_q1, num_ones_q2, num_ones_q3, agree_q0, agree_q1, agree_q2, agree_q3) = res;
                Console.WriteLine(
                    $"Init: {initialState, -4}    0sq0 = {num_zeros_q0, -4}    0sq1 = {num_zeros_q1, -4}    0sq2={num_zeros_q2, -4}    0sq3={num_zeros_q3, -4}    1sq0 = {num_ones_q0, -4}    1sq1 = {num_ones_q1, -4}    1sq2={num_ones_q2, -4}    1sq0 = {num_ones_q3, -4}    agree0 = {agree_q0, -4}    agree1 = {agree_q1, -4}    agree2={agree_q2, -4}    agree3 = {agree_q3, -4}"
                );
                Console.WriteLine();
            }
        }

        public static void ExecGrover4Qubit2(Result initialState, int shots = 1024)
        {
            stopwatch = new Stopwatch();
            Helper.Print("Grover 4 Qubits: ");
            Helper.StartTime(stopwatch);
            using (QuantumSimulator qsim = new QuantumSimulator())
            {
                var res = Grover4Qubit2.Run(qsim, shots, initialState).Result;
                for (int i = 0; i < res.Count; i++)
                {
                    Console.WriteLine(Int32.Parse(Convert.ToString(i, 2)).ToString("0000") + ": " + res[long.Parse(i.ToString())]);
                }
            }
            Helper.OperationTime(stopwatch);
        }
        
        // Do Bell states test
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
    }
}