namespace qsBell.Bell
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Measurement;

    /// Reflect about basis state marked by alternating 0s and 1s
    operation ReflectAboutMarked(inputQubits : Qubit[]) : Unit
    {
        Message("Reflecting about marked state..");
        using(outputQubit = Qubit())
        {
            within
            {
                // initialize output to (|0> - |1>) / √2, toggling to (-1) phase
                X(outputQubit);
                H(outputQubit);
                // flip the output with X gate
                ApplyToEachA(X, inputQubits[...2...]);

            }
            apply
            {
                Controlled X(inputQubits, outputQubit);
            }
        }
    }

    /// Reflect about the uniform superposition state
    operation ReflectAboutUniform(inputQubits : Qubit[]) : Unit
    {
        within
        {
            // transofrm a uniform superposition to all zeros
            Adjoint PrepareUniform(inputQubits);
            // transofrm all zeros to all ones
            PrepareAllOnes(inputQubits);
        }
        apply
        {
            // reflect about all ones state and transofrm back
            ReflectAboutAllOnes(inputQubits);
        }
    }

    /// Reflects about all ones state
    operation ReflectAboutAllOnes(inputQubits : Qubit[]) : Unit
    {
        Controlled Z(Most(inputQubits), Tail(inputQubits));
    }

    /// Prepare a uniform superposition over all basis states given all zeros state
    operation PrepareUniform(inputQubits : Qubit[]) : Unit is Adj + Ctl
    {
        ApplyToEachCA(H, inputQubits);
    }

    /// Prepare all ones state with X gate given all zeros state
    operation PrepareAllOnes(inputQubits : Qubit[]) : Unit is Adj + Ctl
    {
        ApplyToEachCA(X, inputQubits);
    }
}