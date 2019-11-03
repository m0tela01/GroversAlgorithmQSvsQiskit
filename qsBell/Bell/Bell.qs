
namespace qsBell.Bell 
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;

    operation Set(desired : Result, q1 : Qubit) : Unit {
        if (desired != M(q1)) {
            X(q1);
        }
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
                CX(q2,q1);
                // qc.u1(-pi/8, q[2])
                // qc.u1(-pi/8,q[3])
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q2,q1);
                // qc.u1(-pi/8,q[2])
                CX(q2,q1);
                // qc.u1(pi/8,q[2])
                // qc.u1(pi/8,q[3])
                CX(q3,q1);
                // qc.u1(-pi/8,q[2])
                CX(q3,q1);
                // qc.u1(pi/8,q[2])
                // qc.u1(-pi/8,q[4])                
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
                CX(q2,q1);
                // qc.u1(-pi/8, q[2])
                // qc.u1(-pi/8,q[3])
                ////////////////////
                H(q2);
                H(q3);
                CX(q2,q3);
                H(q2);
                H(q3);
                ////////////////////
                CX(q2,q1);
                // qc.u1(-pi/8,q[2])
                CX(q2,q1);
                // qc.u1(pi/8,q[2])
                // qc.u1(pi/8,q[3])
                CX(q3,q1);
                // qc.u1(-pi/8,q[2])
                CX(q3,q1);
                // qc.u1(pi/8,q[2])
                // qc.u1(-pi/8,q[4])                
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
}
