#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"RPiOver8\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"RPiOver8\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"RPiOver8\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":48}},\"Documentation\":[\"automatically generated QsAdjoint specialization for qsBell.Bell.RPiOver8\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"RPiOver8\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":48}},\"Documentation\":[\"automatically generated QsControlled specialization for qsBell.Bell.RPiOver8\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"RPiOver8\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":48}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for qsBell.Bell.RPiOver8\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"TestPaulRZ\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"TestPaulRZ\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"TestBellState\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":50,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"TestBellState\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":50,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover2Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover2Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover3Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover3Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover4Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":268,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"Grover4Qubit\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs\",\"Position\":{\"Item1\":268,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
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
#line 10 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            if ((desired != MicrosoftQuantumIntrinsicM.Apply(q1)))
            {
#line 11 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
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

    public partial class RPiOver8 : Unitary<Qubit>, ICallable
    {
        public RPiOver8(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RPiOver8";
        String ICallable.FullName => "qsBell.Bell.RPiOver8";
        protected IUnitary<(Pauli,Double,Qubit)> MicrosoftQuantumIntrinsicR
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line 16 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, (MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 8D), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => (__in__) =>
        {
            var q = __in__;
#line hidden
            MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, (MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 8D), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,q) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicR.Controlled.Apply((__controlQubits__, (Pauli.PauliZ, (MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 8D), q)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,q) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicR.Adjoint.Controlled.Apply((__controlQubits__, (Pauli.PauliZ, (MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 8D), q)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicR = this.Factory.Get<IUnitary<(Pauli,Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<RPiOver8, Qubit, QVoid>(q);
        }
    }

    public partial class TestPaulRZ : Operation<(Int64,Result), (Int64,Int64)>, ICallable
    {
        public TestPaulRZ(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Result)>, IApplyData
        {
            public In((Int64,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestPaulRZ";
        String ICallable.FullName => "qsBell.Bell.TestPaulRZ";
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

        protected IUnitary<(Pauli,Double,Qubit)> MicrosoftQuantumIntrinsicR
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

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Int64,Result), (Int64,Int64)> Body => (__in__) =>
        {
            var (count,initial) = __in__;
#line 21 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 23 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var theta = (MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 8D);
#line hidden
            {
#line 24 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                var q0 = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 26 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 28 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 29 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 32 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q0));
#line 33 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q0));
#line 35 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 38 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 40 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 42 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 45 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((Result.Zero, q0));
                    }
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
                }
            }

#line 48 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            return ((count - numOnes), numOnes);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicR = this.Factory.Get<IUnitary<(Pauli,Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Int64,Result) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<TestPaulRZ, (Int64,Result), (Int64,Int64)>((count, initial));
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
#line 53 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 54 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line hidden
            {
#line 55 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                var (q0,q1) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 57 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 59 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 60 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((Result.Zero, q1));
#line 63 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 64 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((q0, q1));
#line 66 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 68 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 70 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 74 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 76 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }
                    }

#line 80 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 81 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
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

#line 85 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
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
#line 90 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 91 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq1 = 0L;
#line 92 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line 93 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree1 = 0L;
#line hidden
            {
#line 94 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                var (q0,q1) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 96 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 98 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 99 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q1));
#line 102 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 103 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 104 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCZ.Apply((q1, q0));
#line 105 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 106 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 108 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 109 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 110 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCZ.Apply((q1, q0));
#line 111 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 112 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 113 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 114 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 117 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 118 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 120 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q0) == res))
                        {
#line 122 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 125 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 127 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree1 = (agree1 + 1L);
                        }

#line 131 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 133 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 135 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res1 == Result.One))
                        {
#line 137 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq1 = (numOnesq1 + 1L);
                        }
                    }

#line 141 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 142 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
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

#line 146 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
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
#line 151 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 152 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq1 = 0L;
#line 153 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq2 = 0L;
#line 155 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line 156 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree1 = 0L;
#line 157 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree2 = 0L;
#line hidden
            {
#line 159 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                var (q0,q1,q2) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 161 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 163 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 164 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 165 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 171 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 172 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 173 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 175 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 176 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 177 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 178 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 179 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 180 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 181 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 182 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 183 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 184 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 185 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q2);
#line 187 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 188 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 189 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 191 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 192 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 193 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 195 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 196 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 197 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 198 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 199 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 200 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 201 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q0));
#line 202 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 203 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 204 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 205 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q2);
#line 207 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 208 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 209 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 211 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 212 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 213 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 223 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 224 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 225 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res2 = MicrosoftQuantumIntrinsicM.Apply(q2);
#line 227 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q0) == res))
                        {
#line 229 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 232 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 234 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree1 = (agree1 + 1L);
                        }

#line 237 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q2) == res))
                        {
#line 239 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree2 = (agree2 + 1L);
                        }

#line 243 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 245 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 248 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res1 == Result.One))
                        {
#line 250 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq1 = (numOnesq1 + 1L);
                        }

#line 253 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res2 == Result.One))
                        {
#line 255 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq2 = (numOnesq2 + 1L);
                        }
                    }

#line 259 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 260 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q1));
#line 261 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
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

#line 265 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
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

        protected IUnitary<(Pauli,Double,Qubit)> MicrosoftQuantumIntrinsicR
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

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
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
#line 271 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnes = 0L;
#line 272 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq1 = 0L;
#line 273 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq2 = 0L;
#line 274 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var numOnesq3 = 0L;
#line 276 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree = 0L;
#line 277 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree1 = 0L;
#line 278 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree2 = 0L;
#line 279 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var agree3 = 0L;
#line 281 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            var theta = (MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 8D);
#line hidden
            {
#line 283 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                var (q0,q1,q2,q3) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 285 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    foreach (var test in new Range(1L, count))
#line hidden
                    {
#line 287 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q0));
#line 288 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q1));
#line 289 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q2));
#line 290 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        Set.Apply((initial, q3));
#line 293 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 294 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 295 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 296 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 298 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 299 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 300 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 301 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 302 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 303 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 304 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 305 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 307 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 308 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 309 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 311 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 312 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 313 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 314 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 315 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 316 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 318 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 319 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 320 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 321 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 322 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 323 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 324 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 326 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 327 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 328 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 329 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 330 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 331 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 332 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 333 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 334 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 335 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 336 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 337 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 338 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 339 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 340 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 341 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 343 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 344 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 345 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 346 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 347 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 348 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 350 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 351 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 352 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 353 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 354 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 355 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 356 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 358 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 359 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 360 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 361 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 362 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 364 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 365 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 366 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 367 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 368 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 370 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 371 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 372 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 373 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 374 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 375 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 376 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 377 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 379 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q1));
#line 380 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 382 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q1));
#line 384 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q2));
#line 386 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 387 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 388 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 389 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 390 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 392 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 394 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q1));
#line 395 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 397 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q1));
#line 399 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q2));
#line 400 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 402 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q1));
#line 403 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 405 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q1));
#line 407 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q3));
#line 409 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 410 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 411 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 412 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 413 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 414 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 415 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 418 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 419 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 420 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 421 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 423 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 424 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 425 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 426 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q3);
#line 431 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 432 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 433 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 434 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 435 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 436 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 437 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 438 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 440 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 441 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 442 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 444 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 445 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 446 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 447 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 448 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 449 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 451 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 452 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 453 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 454 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 455 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 456 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 457 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 459 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 460 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 461 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 462 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 463 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 464 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 465 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 466 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 467 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 468 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 469 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 470 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q1);
#line 471 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 472 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 473 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 474 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 476 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 477 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 478 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 479 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 480 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 481 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q2);
#line 483 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 484 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 485 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 486 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 487 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 488 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicS.Apply(q2);
#line 489 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q3);
#line 491 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 492 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Adjoint.Apply(q0);
#line 493 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 494 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q0);
#line 495 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicT.Apply(q1);
#line 497 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 498 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 499 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 500 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 501 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 503 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 504 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 505 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 506 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 507 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 508 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 509 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 510 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 512 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q1));
#line 513 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 515 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q1));
#line 517 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q2));
#line 519 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 520 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 521 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q3));
#line 522 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 523 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 525 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 527 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q1));
#line 528 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q2, q1));
#line 530 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q1));
#line 532 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q2));
#line 533 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 535 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q1));
#line 536 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q3, q1));
#line 538 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Apply((Pauli.PauliZ, theta, q1));
#line 540 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicR.Adjoint.Apply((Pauli.PauliZ, theta, q3));
#line 542 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 543 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 544 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 545 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 546 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 547 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 548 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumCanonCX.Apply((q1, q0));
#line 550 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 551 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q1);
#line 552 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q2);
#line 553 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q3);
#line 555 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q0);
#line 556 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q1);
#line 557 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q2);
#line 558 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q3);
#line 571 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 572 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 573 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res2 = MicrosoftQuantumIntrinsicM.Apply(q2);
#line 574 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        var res3 = MicrosoftQuantumIntrinsicM.Apply(q3);
#line 577 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q0) == res))
                        {
#line 579 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree = (agree + 1L);
                        }

#line 582 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q1) == res))
                        {
#line 584 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree1 = (agree1 + 1L);
                        }

#line 587 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q2) == res))
                        {
#line 589 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree2 = (agree2 + 1L);
                        }

#line 592 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q3) == res))
                        {
#line 594 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            agree3 = (agree3 + 1L);
                        }

#line 598 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res == Result.One))
                        {
#line 600 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 603 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res1 == Result.One))
                        {
#line 605 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq1 = (numOnesq1 + 1L);
                        }

#line 608 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res2 == Result.One))
                        {
#line 610 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq2 = (numOnesq2 + 1L);
                        }

#line 613 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                        if ((res3 == Result.One))
                        {
#line 615 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                            numOnesq3 = (numOnesq3 + 1L);
                        }
                    }

#line 619 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q0));
#line 620 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q1));
#line 621 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
                    Set.Apply((Result.Zero, q2));
#line 622 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
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

#line 626 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Bell.qs"
            return ((count - numOnes), (count - numOnesq1), (count - numOnesq2), (count - numOnesq3), numOnes, numOnesq1, numOnesq2, numOnesq3, agree, agree1, agree2, agree3);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonCX = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Canon.CX));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicR = this.Factory.Get<IUnitary<(Pauli,Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
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