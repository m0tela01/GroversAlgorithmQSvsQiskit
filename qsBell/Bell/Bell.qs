
namespace qsBell.Bell 
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Convert;
    
    operation CreateGrover2OutputStrings() : Int[]
    {
        mutable output = new Int[4];
        set output w/= 0 <- ResultArrayAsInt([Zero,Zero]);
        set output w/= 1 <- ResultArrayAsInt([Zero,One]);
        set output w/= 2 <- ResultArrayAsInt([One,Zero]);
        set output w/= 3 <- ResultArrayAsInt([One,One]);
        return output;
    }    

    operation CreateGrover3OutputStrings() : Int[]
    {
        mutable output = new Int[8];
        set output w/= 0 <- ResultArrayAsInt([Zero,Zero,Zero]);
        set output w/= 1 <- ResultArrayAsInt([Zero,Zero,One]);
        set output w/= 2 <- ResultArrayAsInt([Zero,One,Zero]);
        set output w/= 3 <- ResultArrayAsInt([Zero,One,One]);
        set output w/= 4 <- ResultArrayAsInt([One,Zero,Zero]);
        set output w/= 5 <- ResultArrayAsInt([One,Zero,One]);
        set output w/= 6 <- ResultArrayAsInt([One,One,Zero]);
        set output w/= 7 <- ResultArrayAsInt([One,One,One]);
        return output;
    }    

    operation CreateGrover4OutputStrings() : Int[]
    {
        mutable output = new Int[16];
        set output w/= 0 <- ResultArrayAsInt([Zero,Zero,Zero,Zero]);
        set output w/= 1 <- ResultArrayAsInt([Zero,Zero,Zero,One]);
        set output w/= 2 <- ResultArrayAsInt([Zero,Zero,One,Zero]);
        set output w/= 3 <- ResultArrayAsInt([Zero,Zero,One,One]);
        set output w/= 4 <- ResultArrayAsInt([Zero,One,Zero,Zero]);
        set output w/= 5 <- ResultArrayAsInt([Zero,One,Zero,One]);
        set output w/= 6 <- ResultArrayAsInt([Zero,One,One,Zero]);
        set output w/= 7 <- ResultArrayAsInt([Zero,One,One,One]);
        set output w/= 8 <- ResultArrayAsInt([One,Zero,Zero,Zero]);
        set output w/= 9 <- ResultArrayAsInt([One,Zero,Zero,One]);
        set output w/= 10 <- ResultArrayAsInt([One,Zero,One,Zero]);
        set output w/= 11 <- ResultArrayAsInt([One,Zero,One,One]);
        set output w/= 12 <- ResultArrayAsInt([One,One,Zero,Zero]);
        set output w/= 13 <- ResultArrayAsInt([One,One,Zero,One]);
        set output w/= 14 <- ResultArrayAsInt([One,One,One,Zero]);
        set output w/= 15 <- ResultArrayAsInt([One,One,One,One]);
        return output;
    }    

    operation Set(desired : Result, q1 : Qubit) : Unit {
        if (desired != M(q1)) {
            X(q1);
        }
    }
    
    operation RPiOver8 (q: Qubit) : Unit is Adj+Ctl {
        R(PauliZ, PI() / 8.0, q);
    }

    operation TestPaulRZ(count : Int, initial : Result) : (Int, Int)
    {
        mutable numOnes = 0;
        
        let theta = PI() / 8.0;
        using (q0 = Qubit())
        {
            for (test in 1..count) 
            {
                Set(initial, q0);
                H(q0);

                // RPiOver8(q0);
                R(PauliZ, theta, q0);
                R(PauliZ, theta, q0);

                Adjoint T(q0);


                let res  = M(q0);
                // Count the number of ones we saw:
                if (res == One) 
                {
                    set numOnes += 1;
                }
                // reset qubits before finishing
                Set(Zero, q0);
            }
        }
        return (count-numOnes, numOnes);
    }
    
    operation TestBellState(count : Int, initial : Result) : (Int, Int, Int) 
    {
        mutable numOnes = 0;
        mutable agree = 0;
        using ((q0, q1) = (Qubit(), Qubit())) 
        {
            for (test in 1..count) 
            {
                Set(initial, q0);
                Set(Zero, q1);
                
                // Operations
                H(q0);
                CNOT(q0, q1);

                let res = M(q0);

                if (M(q1) == res)
                {
                    set agree += 1;
                }

                // Count the number of ones we saw:
                if (res == One) 
                {
                    set numOnes += 1;
                }
            }
            // reset qubits before finishing
            Set(Zero, q0);
            Set(Zero, q1);
        }

        // Return number of times we saw a |0> and number of times we saw a |1>
        return (count-numOnes, numOnes, agree);
    }
    
    operation Grover2Qubit(count : Int, initial : Result) : (Int, Int, Int, Int, Int, Int) 
    {
        mutable numOnes = 0;
        mutable numOnesq1 = 0;
        mutable agree = 0;
        mutable agree1 = 0;
        using ((q0, q1) = (Qubit(), Qubit())) 
        {
            for (test in 1..count) 
            {
                Set(initial, q0);
                Set(initial, q1);
                
                // Operations
                H(q0);
                H(q1);
                CZ(q1, q0);
                H(q0);
                H(q1);
                
                X(q0);
                X(q1);
                CZ(q1, q0);
                X(q0);
                X(q1);                
                H(q0);
                H(q1);
                                

                let res = M(q0);
                let res1 = M(q1);

                if (M(q0) == res)
                {
                    set agree += 1;
                }

                if (M(q1) == res)
                {
                    set agree1 += 1;
                }

                // Count the number of ones we saw:
                if (res == One) 
                {
                    set numOnes += 1;
                }
                if (res1 == One)
                {
                    set numOnesq1 += 1;
                }
            }
            // reset qubits before finishing
            Set(Zero, q0);
            Set(Zero, q1);
        }

        // Return number of times we saw a |0> and number of times we saw a |1>
        return (count-numOnes, count-numOnesq1, numOnes, numOnesq1, agree, agree1);
    }

    operation Grover2Qubit2(count : Int, initial : Result) : Int[] 
    {
        mutable output = new Int[16];
        let expectedOutputValues = CreateGrover2OutputStrings();
        using ((q0, q1) = (Qubit(), Qubit())) 
        {
            for (test in 1..count) 
            {
                Set(initial, q0);
                Set(initial, q1);
                
                // Operations
                H(q0);
                H(q1);
                CZ(q1, q0);
                H(q0);
                H(q1);
                
                X(q0);
                X(q1);
                CZ(q1, q0);
                X(q0);
                X(q1);                
                H(q0);
                H(q1);
                                

                let res = M(q0);
                let res1 = M(q1);

                let outputRes = [res1,res];
                mutable counter = 0;
                for (outcome in expectedOutputValues)
                {
                    if (outcome == ResultArrayAsInt(outputRes))
                    {
                        let currentCountOfValueInOutput = output[counter];
                        set output w/= counter <- currentCountOfValueInOutput + 1;
                    }
                    set counter += 1;
                }
            }
            // reset qubits before finishing
            Set(Zero, q0);
            Set(Zero, q1);
        }

        // Return number of times we saw a |0> and number of times we saw a |1>
        return output;
    }

    operation Grover3Qubit(count : Int, initial : Result) : (Int, Int, Int, Int, Int, Int, Int, Int, Int) 
    {
        mutable numOnes = 0;
        mutable numOnesq1 = 0;
        mutable numOnesq2 = 0;

        mutable agree = 0;
        mutable agree1 = 0;
        mutable agree2 = 0;

        using ((q0, q1, q2) = (Qubit(), Qubit(), Qubit())) 
        {
            for (test in 1..count) 
            {
                Set(initial, q0);
                Set(initial, q0);
                Set(initial, q0);
                // Set(initial, q0);
                // Set(initial, q1);
                // Set(initial, q2);
                
                // Operations
                H(q0);
                H(q1);
                H(q2);
                ////////////////////
                CX(q1, q0);
                Adjoint T(q0);
                CX(q2, q0);
                T(q0);
                CX(q1, q0);
                Adjoint T(q0);
                CX(q2, q0);
                T(q0);
                T(q1);
                CX(q2, q1);
                T(q2);
                ////////////////////
                H(q0);
                H(q1);
                H(q2);                
                ////////////////////
                X(q0);
                X(q1);
                X(q2);                
                ////////////////////
                CX(q1, q0);
                Adjoint T(q0);
                CX(q2, q0);
                T(q0);
                CX(q1, q0);
                Adjoint T(q0);
                CX(q2, q0);
                T(q0);
                T(q1);
                CX(q2, q1);
                T(q2);                
                ////////////////////
                X(q0);
                X(q1);
                X(q2);      
                ////////////////////
                H(q0);
                H(q1);
                H(q2);                   
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////

                                

                let res = M(q0);
                let res1 = M(q1);
                let res2 = M(q2);

                if (M(q0) == res)
                {
                    set agree += 1;
                }

                if (M(q1) == res)
                {
                    set agree1 += 1;
                }
                
                if (M(q2) == res)
                {
                    set agree2 += 1;
                }

                // Count the number of ones we saw:
                if (res == One) 
                {
                    set numOnes += 1;
                }

                if (res1 == One)
                {
                    set numOnesq1 += 1;
                }

                if (res2 == One)
                {
                    set numOnesq2 += 1;
                }
            }
            // reset qubits before finishing
            Set(Zero, q0);
            Set(Zero, q1);
            Set(Zero, q2);
        }

        // Return number of times we saw a |0> and number of times we saw a |1>
        return (count-numOnes, count-numOnesq1, count-numOnesq2, numOnes, numOnesq1, numOnesq2, agree, agree1, agree2);
    }

    operation Grover3Qubit2(count : Int, initial : Result) : Int[]
    {
        mutable output = new Int[16];
        let expectedOutputValues = CreateGrover3OutputStrings();

        using ((q0, q1, q2) = (Qubit(), Qubit(), Qubit())) 
        {
            for (test in 1..count) 
            {
                Set(initial, q0);
                Set(initial, q0);
                Set(initial, q0);
                // Set(initial, q0);
                // Set(initial, q1);
                // Set(initial, q2);
                
                // Operations
                H(q0);
                H(q1);
                H(q2);
                ////////////////////
                CX(q1, q0);
                Adjoint T(q0);
                CX(q2, q0);
                T(q0);
                CX(q1, q0);
                Adjoint T(q0);
                CX(q2, q0);
                T(q0);
                T(q1);
                CX(q2, q1);
                T(q2);
                ////////////////////
                H(q0);
                H(q1);
                H(q2);                
                ////////////////////
                X(q0);
                X(q1);
                X(q2);                
                ////////////////////
                CX(q1, q0);
                Adjoint T(q0);
                CX(q2, q0);
                T(q0);
                CX(q1, q0);
                Adjoint T(q0);
                CX(q2, q0);
                T(q0);
                T(q1);
                CX(q2, q1);
                T(q2);                
                ////////////////////
                X(q0);
                X(q1);
                X(q2);      
                ////////////////////
                H(q0);
                H(q1);
                H(q2);                   
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////

                                

                let res = M(q0);
                let res1 = M(q1);
                let res2 = M(q2);

                let outputRes = [res2,res1,res];
                mutable counter = 0;
                for (outcome in expectedOutputValues)
                {
                    if (outcome == ResultArrayAsInt(outputRes))
                    {
                        let currentCountOfValueInOutput = output[counter];
                        set output w/= counter <- currentCountOfValueInOutput + 1;
                    }
                    set counter += 1;
                }
            }
            // reset qubits before finishing
            Set(Zero, q0);
            Set(Zero, q1);
            Set(Zero, q2);
        }

        // Return number of times we saw a |0> and number of times we saw a |1>
        return output;
    }
   

    operation Grover4Qubit(count : Int, initial : Result) : (Int, Int, Int, Int, Int, Int, Int, Int, Int, Int, Int, Int) 
    {
        mutable numOnes = 0;
        mutable numOnesq1 = 0;
        mutable numOnesq2 = 0;
        mutable numOnesq3 = 0;

        mutable agree = 0;
        mutable agree1 = 0;
        mutable agree2 = 0;
        mutable agree3 = 0;

        let theta = PI() / 8.0;

        using ((q0, q1, q2, q3) = (Qubit(), Qubit(), Qubit(), Qubit())) 
        {
            for (test in 1..count) 
            {
                Set(initial, q0);
                Set(initial, q1);
                Set(initial, q2);
                Set(initial, q3);
                
                // Operations
                H(q0);
                H(q1);
                H(q2);
                H(q3);
                ////////////////////
                H(q1);
                CX(q2, q1);
                Adjoint T(q1);
                CX(q3, q1);
                T(q1);
                CX(q2, q1);
                Adjoint T(q1);
                CX(q3, q1);
                ////////////////////
                T(q1);
                Adjoint T(q2);
                H(q1);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2, q3);
                H(q2);
                H(q3);
                Adjoint T(q2);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2, q3);
                H(q2);
                H(q3);                
                S(q2);
                T(q3);
                ////////////////////     
                CX(q1,q0);
                T(q0);
                CX(q1,q0);
                Adjoint T(q0);
                Adjoint T(q1);
                H(q1);
                CX(q2,q1);
                Adjoint T(q1);
                CX(q3,q1);
                T(q1);
                CX(q2,q1);
                Adjoint T(q1);
                CX(q3,q1);
                T(q1);
                Adjoint T(q2);
                H(q1);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                Adjoint T(q2);              
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                S(q2);
                T(q3);
                ////////////////////
                CX(q1,q0);
                Adjoint T(q0);
                CX(q1,q0);
                T(q0);
                T(q1);

                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                CX(q2,q1);
                // qc.u1(pi/8, q[2])
                R(PauliZ, theta, q1);
                CX(q2,q1);
                // qc.u1(-pi/8, q[2])
                Adjoint R(PauliZ, theta, q1);
                // qc.u1(-pi/8,q[3])
                Adjoint R(PauliZ, theta, q2);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q2,q1);
                // qc.u1(-pi/8,q[2])
                Adjoint R(PauliZ, theta, q1);
                CX(q2,q1);
                // qc.u1(pi/8,q[2])
                R(PauliZ, theta, q1);
                // qc.u1(pi/8,q[3])
                R(PauliZ, theta, q2);
                CX(q3,q1);
                // qc.u1(-pi/8,q[2])
                Adjoint R(PauliZ, theta, q1);
                CX(q3,q1);
                // qc.u1(pi/8,q[2])
                R(PauliZ, theta, q1);
                // qc.u1(-pi/8,q[4])                
                Adjoint R(PauliZ, theta, q3);
                ////////////////////
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                ////////////////////
                ////////////////////
                H(q0);
                H(q1);
                H(q2);
                H(q3);
                ////////////////////
                X(q0);
                X(q1);
                X(q2);
                X(q3);
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                H(q1);
                CX(q2, q1);
                Adjoint T(q1);
                CX(q3, q1);
                T(q1);
                CX(q2, q1);
                Adjoint T(q1);
                CX(q3, q1);
                ////////////////////
                T(q1);
                Adjoint T(q2);
                H(q1);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2, q3);
                H(q2);
                H(q3);
                Adjoint T(q2);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2, q3);
                H(q2);
                H(q3);                
                S(q2);
                T(q3);
                ////////////////////     
                CX(q1,q0);
                T(q0);
                CX(q1,q0);
                Adjoint T(q0);
                Adjoint T(q1);
                H(q1);
                CX(q2,q1);
                Adjoint T(q1);
                CX(q3,q1);
                T(q1);
                CX(q2,q1);
                Adjoint T(q1);
                CX(q3,q1);
                T(q1);
                Adjoint T(q2);
                H(q1);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                Adjoint T(q2);              
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                S(q2);
                T(q3);
                ////////////////////
                CX(q1,q0);
                Adjoint T(q0);
                CX(q1,q0);
                T(q0);
                T(q1);

                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                CX(q2,q1);
                // qc.u1(pi/8, q[2])
                R(PauliZ, theta, q1);
                CX(q2,q1);
                // qc.u1(-pi/8, q[2])
                Adjoint R(PauliZ, theta, q1);
                // qc.u1(-pi/8,q[3])
                Adjoint R(PauliZ, theta, q2);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q2,q1);
                // qc.u1(-pi/8,q[2])
                Adjoint R(PauliZ, theta, q1);
                CX(q2,q1);
                // qc.u1(pi/8,q[2])
                R(PauliZ, theta, q1);
                // qc.u1(pi/8,q[3])
                R(PauliZ, theta, q2);
                CX(q3,q1);
                // qc.u1(-pi/8,q[2])
                Adjoint R(PauliZ, theta, q1);
                CX(q3,q1);
                // qc.u1(pi/8,q[2])
                R(PauliZ, theta, q1);
                // qc.u1(-pi/8,q[4])                
                Adjoint R(PauliZ, theta, q3);
                ////////////////////
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);                
                ////////////////////
                X(q0);
                X(q1);
                X(q2);
                X(q3);                
                ////////////////////
                H(q0);
                H(q1);
                H(q2);
                H(q3);
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////

                                
                // perform measure
                let res = M(q0);
                let res1 = M(q1);
                let res2 = M(q2);
                let res3 = M(q3);

                // count measure measure
                if (M(q0) == res)
                {
                    set agree += 1;
                }

                if (M(q1) == res)
                {
                    set agree1 += 1;
                }
                
                if (M(q2) == res)
                {
                    set agree2 += 1;
                }

                if (M(q3) == res)
                {
                    set agree3 += 1;
                }                

                // Count the number of ones we saw:
                if (res == One) 
                {
                    set numOnes += 1;
                }

                if (res1 == One)
                {
                    set numOnesq1 += 1;
                }

                if (res2 == One)
                {
                    set numOnesq2 += 1;
                }

                if (res3 == One)
                {
                    set numOnesq3 += 1;
                }                
            }
            // reset qubits before finishing
            Set(Zero, q0);
            Set(Zero, q1);
            Set(Zero, q2);
            Set(Zero, q3);
        }

        // Return number of times we saw a |0> and number of times we saw a |1>
        return (count-numOnes, count-numOnesq1, count-numOnesq2, count-numOnesq3, numOnes, numOnesq1, numOnesq2, numOnesq3, agree, agree1, agree2, agree3);
    }
    


    operation Grover4Qubit2(count : Int, initial : Result) : Int[]
    {
        mutable output = new Int[16];
        let expectedOutputValues = CreateGrover4OutputStrings();
        let theta = PI() / 8.0;

        using ((q0, q1, q2, q3) = (Qubit(), Qubit(), Qubit(), Qubit())) 
        {
            for (test in 1..count) 
            {
                Set(initial, q0);
                Set(initial, q1);
                Set(initial, q2);
                Set(initial, q3);
                
                // Operations
                H(q0);
                H(q1);
                H(q2);
                H(q3);
                ////////////////////
                H(q1);
                CX(q2, q1);
                Adjoint T(q1);
                CX(q3, q1);
                T(q1);
                CX(q2, q1);
                Adjoint T(q1);
                CX(q3, q1);
                ////////////////////
                T(q1);
                Adjoint T(q2);
                H(q1);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2, q3);
                H(q2);
                H(q3);
                Adjoint T(q2);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2, q3);
                H(q2);
                H(q3);                
                S(q2);
                T(q3);
                ////////////////////     
                CX(q1,q0);
                T(q0);
                CX(q1,q0);
                Adjoint T(q0);
                Adjoint T(q1);
                H(q1);
                CX(q2,q1);
                Adjoint T(q1);
                CX(q3,q1);
                T(q1);
                CX(q2,q1);
                Adjoint T(q1);
                CX(q3,q1);
                T(q1);
                Adjoint T(q2);
                H(q1);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                Adjoint T(q2);              
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                S(q2);
                T(q3);
                ////////////////////
                CX(q1,q0);
                Adjoint T(q0);
                CX(q1,q0);
                T(q0);
                T(q1);

                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                CX(q2,q1);
                // qc.u1(pi/8, q[2])
                R(PauliZ, theta, q1);
                CX(q2,q1);
                // qc.u1(-pi/8, q[2])
                Adjoint R(PauliZ, theta, q1);
                // qc.u1(-pi/8,q[3])
                Adjoint R(PauliZ, theta, q2);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q2,q1);
                // qc.u1(-pi/8,q[2])
                Adjoint R(PauliZ, theta, q1);
                CX(q2,q1);
                // qc.u1(pi/8,q[2])
                R(PauliZ, theta, q1);
                // qc.u1(pi/8,q[3])
                R(PauliZ, theta, q2);
                CX(q3,q1);
                // qc.u1(-pi/8,q[2])
                Adjoint R(PauliZ, theta, q1);
                CX(q3,q1);
                // qc.u1(pi/8,q[2])
                R(PauliZ, theta, q1);
                // qc.u1(-pi/8,q[4])                
                Adjoint R(PauliZ, theta, q3);
                ////////////////////
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                ////////////////////
                ////////////////////
                H(q0);
                H(q1);
                H(q2);
                H(q3);
                ////////////////////
                X(q0);
                X(q1);
                X(q2);
                X(q3);
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                H(q1);
                CX(q2, q1);
                Adjoint T(q1);
                CX(q3, q1);
                T(q1);
                CX(q2, q1);
                Adjoint T(q1);
                CX(q3, q1);
                ////////////////////
                T(q1);
                Adjoint T(q2);
                H(q1);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2, q3);
                H(q2);
                H(q3);
                Adjoint T(q2);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2, q3);
                H(q2);
                H(q3);                
                S(q2);
                T(q3);
                ////////////////////     
                CX(q1,q0);
                T(q0);
                CX(q1,q0);
                Adjoint T(q0);
                Adjoint T(q1);
                H(q1);
                CX(q2,q1);
                Adjoint T(q1);
                CX(q3,q1);
                T(q1);
                CX(q2,q1);
                Adjoint T(q1);
                CX(q3,q1);
                T(q1);
                Adjoint T(q2);
                H(q1);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                Adjoint T(q2);              
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                S(q2);
                T(q3);
                ////////////////////
                CX(q1,q0);
                Adjoint T(q0);
                CX(q1,q0);
                T(q0);
                T(q1);

                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                CX(q2,q1);
                // qc.u1(pi/8, q[2])
                R(PauliZ, theta, q1);
                CX(q2,q1);
                // qc.u1(-pi/8, q[2])
                Adjoint R(PauliZ, theta, q1);
                // qc.u1(-pi/8,q[3])
                Adjoint R(PauliZ, theta, q2);
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q2,q1);
                // qc.u1(-pi/8,q[2])
                Adjoint R(PauliZ, theta, q1);
                CX(q2,q1);
                // qc.u1(pi/8,q[2])
                R(PauliZ, theta, q1);
                // qc.u1(pi/8,q[3])
                R(PauliZ, theta, q2);
                CX(q3,q1);
                // qc.u1(-pi/8,q[2])
                Adjoint R(PauliZ, theta, q1);
                CX(q3,q1);
                // qc.u1(pi/8,q[2])
                R(PauliZ, theta, q1);
                // qc.u1(-pi/8,q[4])                
                Adjoint R(PauliZ, theta, q3);
                ////////////////////
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);
                H(q0);
                H(q1);
                CX(q1,q0);                
                ////////////////////
                X(q0);
                X(q1);
                X(q2);
                X(q3);                
                ////////////////////
                H(q0);
                H(q1);
                H(q2);
                H(q3);
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////
                ////////////////////

                                
                // perform measure
                let res = M(q0);
                let res1 = M(q1);
                let res2 = M(q2);
                let res3 = M(q3);

                let outputRes = [res3,res2,res1,res];
                mutable counter = 0;
                for (outcome in expectedOutputValues)
                {
                    if (outcome == ResultArrayAsInt(outputRes))
                    {
                        let currentCountOfValueInOutput = output[counter];
                        set output w/= counter <- currentCountOfValueInOutput + 1;
                    }
                    set counter += 1;
                }
            
            }
            // reset qubits before finishing
            Set(Zero, q0);
            Set(Zero, q1);
            Set(Zero, q2);
            Set(Zero, q3);
        }

        // Return number of times we saw a |0> and number of times we saw a |1>
        return output;
    }
}
