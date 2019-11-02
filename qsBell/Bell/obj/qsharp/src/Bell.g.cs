#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"TestBellState\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"TestBellState\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover2Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover2Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover3Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover3Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover4Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":229,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover4Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":229,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
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
#line 7 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            if ((desired != MicrosoftQuantumIntrinsicM.Apply(q1)))
            {
#line 8 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
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
#line 14 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 15 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line hidden
            {
#line 16 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                var (q0,q1) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 18 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 20 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 21 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((Result.Zero, q1));
#line 24 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 25 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((q0, q1));
#line 27 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 29 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 31 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 35 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 37 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }
                    }

#line 41 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 42 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
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

#line 46 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
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
#line 51 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 52 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnesq1 = 0L;
#line 53 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line 54 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree1 = 0L;
#line hidden
            {
#line 55 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                var (q0,q1) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 57 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 59 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 60 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q1));
#line 63 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 64 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 65 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCZ.Apply((q1, q0));
#line 66 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 67 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 69 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 70 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 71 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCZ.Apply((q1, q0));
#line 72 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 73 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 74 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 75 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 78 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 79 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 81 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q0) == res))
                        {
#line 83 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 86 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 88 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree1 = (agree1 + 1L);
                        }

#line 92 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 94 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 96 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res1 == Result.One))
                        {
#line 98 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnesq1 = (numOnesq1 + 1L);
                        }
                    }

#line 102 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 103 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
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

#line 107 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
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
#line 112 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 113 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnesq1 = 0L;
#line 114 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnesq2 = 0L;
#line 116 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line 117 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree1 = 0L;
#line 118 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree2 = 0L;
#line hidden
            {
#line 120 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                var (q0,q1,q2) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 122 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 124 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 125 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 126 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 132 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 133 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 134 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 136 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 137 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 138 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 139 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 140 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 141 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 142 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 143 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 144 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 145 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 146 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q2);
#line 148 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 149 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 150 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 152 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 153 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 154 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 156 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 157 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 158 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 159 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 160 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 161 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 162 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 163 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 164 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 165 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 166 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q2);
#line 168 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 169 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 170 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 172 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 173 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 174 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 184 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 185 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 186 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res2 = MicrosoftQuantumIntrinsicM.Apply(q2);
#line 188 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q0) == res))
                        {
#line 190 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 193 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 195 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree1 = (agree1 + 1L);
                        }

#line 198 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q2) == res))
                        {
#line 200 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree2 = (agree2 + 1L);
                        }

#line 204 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 206 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 209 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res1 == Result.One))
                        {
#line 211 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnesq1 = (numOnesq1 + 1L);
                        }

#line 214 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res2 == Result.One))
                        {
#line 216 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnesq2 = (numOnesq2 + 1L);
                        }
                    }

#line 220 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 221 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q1));
#line 222 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
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

#line 226 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
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
#line 232 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 233 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnesq1 = 0L;
#line 234 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnesq2 = 0L;
#line 235 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var numOnesq3 = 0L;
#line 237 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line 238 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree1 = 0L;
#line 239 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree2 = 0L;
#line 240 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
            var agree3 = 0L;
#line hidden
            {
#line 242 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                var (q0,q1,q2,q3) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 244 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 246 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 247 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q1));
#line 248 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q2));
#line 249 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q3));
#line 252 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 253 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 254 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 255 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 257 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 258 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 259 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 260 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 261 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 262 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 263 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 264 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 266 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 267 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 268 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 270 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 271 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 272 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 273 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 274 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 275 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 277 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 278 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 279 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 280 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 281 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 282 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 283 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 285 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 286 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 287 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 288 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 289 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 290 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 291 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 292 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 293 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 294 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 295 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 296 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 297 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 298 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 299 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 300 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 302 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 303 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 304 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 305 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 306 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 307 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 309 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 310 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 311 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 312 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 313 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 314 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 315 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 317 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 318 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 319 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 320 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 321 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 323 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 324 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 325 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 326 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 327 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 329 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 330 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 331 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 332 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 333 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 334 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 335 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 336 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 338 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 342 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 343 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 344 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 345 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 346 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 348 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 350 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 353 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 355 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 359 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 360 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 361 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 362 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 363 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 364 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 365 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 368 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 369 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 370 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 371 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 373 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 374 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 375 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 376 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q3);
#line 381 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 382 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 383 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 384 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 385 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 386 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 387 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 388 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 390 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 391 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 392 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 394 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 395 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 396 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 397 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 398 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 399 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 401 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 402 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 403 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 404 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 405 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 406 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 407 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 409 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 410 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 411 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 412 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 413 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 414 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 415 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 416 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 417 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 418 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 419 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 420 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 421 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 422 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 423 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 424 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 426 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 427 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 428 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 429 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 430 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 431 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 433 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 434 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 435 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 436 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 437 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 438 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 439 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 441 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 442 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 443 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 444 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 445 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 447 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 448 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 449 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 450 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 451 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 453 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 454 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 455 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 456 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 457 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 458 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 459 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 460 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 462 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 466 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 467 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 468 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 469 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 470 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 472 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 474 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 477 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 479 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 483 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 484 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 485 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 486 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 487 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 488 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 489 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 491 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 492 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 493 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 494 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q3);
#line 496 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 497 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 498 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 499 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 512 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 513 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 514 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res2 = MicrosoftQuantumIntrinsicM.Apply(q2);
#line 515 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        var res3 = MicrosoftQuantumIntrinsicM.Apply(q3);
#line 518 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q0) == res))
                        {
#line 520 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 523 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 525 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree1 = (agree1 + 1L);
                        }

#line 528 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q2) == res))
                        {
#line 530 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree2 = (agree2 + 1L);
                        }

#line 533 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q3) == res))
                        {
#line 535 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            agree3 = (agree3 + 1L);
                        }

#line 539 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 541 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 544 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res1 == Result.One))
                        {
#line 546 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnesq1 = (numOnesq1 + 1L);
                        }

#line 549 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res2 == Result.One))
                        {
#line 551 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnesq2 = (numOnesq2 + 1L);
                        }

#line 554 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                        if ((res3 == Result.One))
                        {
#line 556 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                            numOnesq3 = (numOnesq3 + 1L);
                        }
                    }

#line 560 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 561 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q1));
#line 562 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q2));
#line 563 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
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

#line 567 "/home/tela/Documents/Q/qsBell/Bell/Bell.qs"
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