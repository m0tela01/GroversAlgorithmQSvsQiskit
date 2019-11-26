#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"SearchForMarkedInput\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"SearchForMarkedInput\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"NIterations\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"NIterations\"},\"Attributes\":[],\"SourceFile\":\"/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
#line hidden
namespace qsBell.Bell
{
    public partial class SearchForMarkedInput : Operation<Int64, IQArray<Result>>, ICallable
    {
        public SearchForMarkedInput(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SearchForMarkedInput";
        String ICallable.FullName => "qsBell.Bell.SearchForMarkedInput";
        protected ICallable MicrosoftQuantumArraysForEach
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> NIterations
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> PrepareUniform
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ReflectAboutMarked
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ReflectAboutUniform
        {
            get;
            set;
        }

        public override Func<Int64, IQArray<Result>> Body => (__in__) =>
        {
            var nQubits = __in__;
#line hidden
            {
#line 10 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
                var qubits = Allocate.Apply(nQubits);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 13 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
                    PrepareUniform.Apply(qubits);
#line 14 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
                    foreach (var index in new Range(0L, (NIterations.Apply(nQubits) - 1L)))
#line hidden
                    {
#line 16 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
                        ReflectAboutMarked.Apply(qubits);
#line 17 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
                        ReflectAboutUniform.Apply(qubits);
                    }

#line 19 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
                    return MicrosoftQuantumArraysForEach.Apply<IQArray<Result>>((MicrosoftQuantumMeasurementMResetZ, qubits));
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
                    Release.Apply(qubits);
                }
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysForEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.ForEach<,>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.NIterations = this.Factory.Get<ICallable<Int64, Int64>>(typeof(NIterations));
            this.PrepareUniform = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(PrepareUniform));
            this.ReflectAboutMarked = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ReflectAboutMarked));
            this.ReflectAboutUniform = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ReflectAboutUniform));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, Int64 nQubits)
        {
            return __m__.Run<SearchForMarkedInput, Int64, IQArray<Result>>(nQubits);
        }
    }

    public partial class NIterations : Function<Int64, Int64>, ICallable
    {
        public NIterations(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "NIterations";
        String ICallable.FullName => "qsBell.Bell.NIterations";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathArcSin
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumMathRound
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSqrt
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in__) =>
        {
            var nQubits = __in__;
#line 26 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
            var nItems = (1L << (int)nQubits);
#line 28 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
            var angle = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(nItems))));
#line 29 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
            var nIterations = MicrosoftQuantumMathRound.Apply((((0.25D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / angle) - 0.5D));
#line 30 "/home/tela/Documents/Q/GroversAlgorithmQSvsQiskit/qsBell/Bell/Operations.qs"
            return nIterations;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.ArcSin));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.MicrosoftQuantumMathRound = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Math.Round));
            this.MicrosoftQuantumMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sqrt));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 nQubits)
        {
            return __m__.Run<NIterations, Int64, Int64>(nQubits);
        }
    }
}