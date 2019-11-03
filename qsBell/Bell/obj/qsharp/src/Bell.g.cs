#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"TestBellState\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"TestBellState\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover2Qubit\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover2Qubit\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover3Qubit\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover3Qubit\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover4Qubit\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":230,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover4Qubit\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":230,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
#line hidden
namespace qsBell.Bell
{
    public partial class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "qsBell.Bell.Set";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desired,q1) = __in__;
#line 8 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            if ((desired != MicrosoftQuantumIntrinsicM.Apply(q1)))
            {
#line 9 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                MicrosoftQuantumIntrinsicX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public partial class TestBellState : Operation<(Int64,Result), (Int64,Int64,Int64)>, ICallable
    {
        public TestBellState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Result)>, IApplyData
        {
            public In((Int64,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestBellState";
        String ICallable.FullName => "qsBell.Bell.TestBellState";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Int64,Result), (Int64,Int64,Int64)> Body => (__in__) =>
        {
            var (count,initial) = __in__;
#line 15 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 16 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line hidden
            {
#line 17 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                var (q0,q1) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 19 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 21 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 22 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((Result.Zero, q1));
#line 25 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 26 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((q0, q1));
#line 28 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 30 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 32 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 36 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 38 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }
                    }

#line 42 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 43 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q1));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q0);
#line hidden
                    Release.Apply(q1);
                }
            }

#line 47 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            return ((count - numOnes), numOnes, agree);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Int64,Result) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<TestBellState, (Int64,Result), (Int64,Int64,Int64)>((count, initial));
        }
    }

    public partial class Grover2Qubit : Operation<(Int64,Result), (Int64,Int64,Int64,Int64,Int64,Int64)>, ICallable
    {
        public Grover2Qubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Result)>, IApplyData
        {
            public In((Int64,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64,Int64,Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Grover2Qubit";
        String ICallable.FullName => "qsBell.Bell.Grover2Qubit";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumCanonCZ
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Int64,Result), (Int64,Int64,Int64,Int64,Int64,Int64)> Body => (__in__) =>
        {
            var (count,initial) = __in__;
#line 52 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 53 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq1 = 0L;
#line 54 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line 55 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree1 = 0L;
#line hidden
            {
#line 56 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                var (q0,q1) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 58 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 60 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 61 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q1));
#line 64 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 65 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 66 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCZ.Apply((q1, q0));
#line 67 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 68 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 70 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 71 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 72 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCZ.Apply((q1, q0));
#line 73 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 74 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 75 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 76 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 79 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 80 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 82 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q0) == res))
                        {
#line 84 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 87 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 89 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree1 = (agree1 + 1L);
                        }

#line 93 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 95 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 97 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res1 == Result.One))
                        {
#line 99 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq1 = (numOnesq1 + 1L);
                        }
                    }

#line 103 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 104 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q1));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q0);
#line hidden
                    Release.Apply(q1);
                }
            }

#line 108 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            return ((count - numOnes), (count - numOnesq1), numOnes, numOnesq1, agree, agree1);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonCZ = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Canon.CZ));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Int64,Result) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64,Int64,Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64,Int64,Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<Grover2Qubit, (Int64,Result), (Int64,Int64,Int64,Int64,Int64,Int64)>((count, initial));
        }
    }

    public partial class Grover3Qubit : Operation<(Int64,Result), (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, ICallable
    {
        public Grover3Qubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Result)>, IApplyData
        {
            public In((Int64,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Grover3Qubit";
        String ICallable.FullName => "qsBell.Bell.Grover3Qubit";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumCanonCX
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Int64,Result), (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Body => (__in__) =>
        {
            var (count,initial) = __in__;
#line 113 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 114 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq1 = 0L;
#line 115 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq2 = 0L;
#line 117 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line 118 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree1 = 0L;
#line 119 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree2 = 0L;
#line hidden
            {
#line 121 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                var (q0,q1,q2) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 123 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 125 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 126 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 127 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 133 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 134 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 135 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 137 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 138 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 139 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 140 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 141 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 142 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 143 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 144 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 145 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 146 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 147 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q2);
#line 149 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 150 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 151 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 153 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 154 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 155 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 157 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 158 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 159 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 160 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 161 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 162 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 163 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 164 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 165 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 166 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 167 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q2);
#line 169 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 170 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 171 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 173 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 174 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 175 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 185 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 186 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 187 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res2 = MicrosoftQuantumIntrinsicM.Apply(q2);
#line 189 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q0) == res))
                        {
#line 191 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 194 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 196 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree1 = (agree1 + 1L);
                        }

#line 199 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q2) == res))
                        {
#line 201 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree2 = (agree2 + 1L);
                        }

#line 205 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 207 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 210 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res1 == Result.One))
                        {
#line 212 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq1 = (numOnesq1 + 1L);
                        }

#line 215 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res2 == Result.One))
                        {
#line 217 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq2 = (numOnesq2 + 1L);
                        }
                    }

#line 221 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 222 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q1));
#line 223 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q2));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q0);
#line hidden
                    Release.Apply(q1);
#line hidden
                    Release.Apply(q2);
                }
            }

#line 227 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            return ((count - numOnes), (count - numOnesq1), (count - numOnesq2), numOnes, numOnesq1, numOnesq2, agree, agree1, agree2);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonCX = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Canon.CX));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Int64,Result) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<Grover3Qubit, (Int64,Result), (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>((count, initial));
        }
    }

    public partial class Grover4Qubit : Operation<(Int64,Result), (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, ICallable
    {
        public Grover4Qubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Result)>, IApplyData
        {
            public In((Int64,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Grover4Qubit";
        String ICallable.FullName => "qsBell.Bell.Grover4Qubit";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumCanonCX
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicS
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Int64,Result), (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Body => (__in__) =>
        {
            var (count,initial) = __in__;
#line 233 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 234 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq1 = 0L;
#line 235 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq2 = 0L;
#line 236 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq3 = 0L;
#line 238 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line 239 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree1 = 0L;
#line 240 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree2 = 0L;
#line 241 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree3 = 0L;
#line hidden
            {
#line 243 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                var (q0,q1,q2,q3) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 245 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 247 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 248 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q1));
#line 249 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q2));
#line 250 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q3));
#line 253 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 254 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 255 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 256 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 258 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 259 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 260 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 261 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 262 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 263 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 264 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 265 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 267 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 268 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 269 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 271 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 272 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 273 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 274 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 275 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 276 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 278 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 279 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 280 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 281 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 282 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 283 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 284 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 286 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 287 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 288 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 289 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 290 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 291 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 292 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 293 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 294 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 295 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 296 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 297 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 298 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 299 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 300 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 301 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 303 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 304 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 305 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 306 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 307 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 308 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 310 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 311 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 312 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 313 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 314 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 315 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 316 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 318 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 319 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 320 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 321 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 322 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 324 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 325 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 326 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 327 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 328 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 330 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 331 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 332 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 333 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 334 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 335 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 336 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 337 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 339 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 343 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 344 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 345 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 346 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 347 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 349 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 351 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 354 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 356 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 360 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 361 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 362 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 363 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 364 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 365 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 366 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 369 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 370 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 371 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 372 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 374 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 375 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 376 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 377 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q3);
#line 382 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 383 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 384 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 385 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 386 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 387 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 388 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 389 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 391 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 392 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 393 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 395 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 396 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 397 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 398 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 399 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 400 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 402 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 403 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 404 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 405 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 406 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 407 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 408 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 410 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 411 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 412 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 413 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 414 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 415 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 416 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 417 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 418 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 419 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 420 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 421 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 422 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 423 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 424 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 425 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 427 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 428 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 429 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 430 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 431 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 432 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 434 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 435 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 436 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 437 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 438 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 439 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 440 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 442 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 443 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 444 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 445 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 446 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 448 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 449 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 450 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 451 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 452 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 454 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 455 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 456 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 457 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 458 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 459 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 460 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 461 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 463 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 467 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 468 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 469 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 470 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 471 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 473 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 475 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 478 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 480 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 484 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 485 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 486 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 487 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 488 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 489 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 490 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 492 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 493 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 494 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 495 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q3);
#line 497 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 498 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 499 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 500 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 513 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 514 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 515 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res2 = MicrosoftQuantumIntrinsicM.Apply(q2);
#line 516 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res3 = MicrosoftQuantumIntrinsicM.Apply(q3);
#line 519 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q0) == res))
                        {
#line 521 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 524 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 526 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree1 = (agree1 + 1L);
                        }

#line 529 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q2) == res))
                        {
#line 531 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree2 = (agree2 + 1L);
                        }

#line 534 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q3) == res))
                        {
#line 536 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree3 = (agree3 + 1L);
                        }

#line 540 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 542 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 545 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res1 == Result.One))
                        {
#line 547 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq1 = (numOnesq1 + 1L);
                        }

#line 550 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res2 == Result.One))
                        {
#line 552 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq2 = (numOnesq2 + 1L);
                        }

#line 555 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res3 == Result.One))
                        {
#line 557 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq3 = (numOnesq3 + 1L);
                        }
                    }

#line 561 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 562 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q1));
#line 563 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q2));
#line 564 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q3));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q0);
#line hidden
                    Release.Apply(q1);
#line hidden
                    Release.Apply(q2);
#line hidden
                    Release.Apply(q3);
                }
            }

#line 568 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            return ((count - numOnes), (count - numOnesq1), (count - numOnesq2), (count - numOnesq3), numOnes, numOnesq1, numOnesq2, numOnesq3, agree, agree1, agree2, agree3);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonCX = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Canon.CX));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Int64,Result) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<Grover4Qubit, (Int64,Result), (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>((count, initial));
        }
    }
}