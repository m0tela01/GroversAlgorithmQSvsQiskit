namespace qsBell.Bell
{
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Measurement;

    operation SearchForMarkedInput(nQubits : Int) : Result[]
    {
        using (qubits = Qubit[nQubits])
        {
            // create uniform superpositinos of all qubits
            PrepareUniform(qubits);
            for (index in 0..NIterations(nQubits) - 1)
            {
                ReflectAboutMarked(qubits);
                ReflectAboutUniform(qubits);
            }
            return ForEach(MResetZ, qubits);
        }
    }

    function NIterations(nQubits : Int) : Int 
    {
        // represents 2^number of qubits
        let nItems = 1 <<< nQubits;
        // compare the iterations
        let angle = ArcSin(1. / Sqrt(IntAsDouble(nItems)));
        let nIterations = Round(0.25 * PI() / angle - 0.5);
        return nIterations;
    }
}