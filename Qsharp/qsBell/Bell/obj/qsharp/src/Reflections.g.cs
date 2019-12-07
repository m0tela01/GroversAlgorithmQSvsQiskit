#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"ReflectAboutMarked\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" Reflect about basis state marked by alternating 0s and 1s\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"ReflectAboutMarked\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"ReflectAboutUniform\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" Reflect about the uniform superposition state\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"ReflectAboutUniform\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"ReflectAboutAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" Reflects about all ones state\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"ReflectAboutAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" Prepare a uniform superposition over all basis states given all zeros state\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsAdjoint specialization for qsBell.Bell.PrepareUniform\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlled specialization for qsBell.Bell.PrepareUniform\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for qsBell.Bell.PrepareUniform\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" Prepare all ones state with X gate given all zeros state\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsAdjoint specialization for qsBell.Bell.PrepareAllOnes\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlled specialization for qsBell.Bell.PrepareAllOnes\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsBell.Bell\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for qsBell.Bell.PrepareAllOnes\"]}")]
#line hidden
namespace qsBell.Bell
{
    public partial class ReflectAboutMarked : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectAboutMarked(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutMarked";
        String ICallable.FullName => "qsBell.Bell.ReflectAboutMarked";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable Length
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

        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
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

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var inputQubits = __in__;
#line 13 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
            MicrosoftQuantumIntrinsicMessage.Apply("Reflecting about marked state..");
#line hidden
            {
#line 14 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
                var outputQubit = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 19 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
                    MicrosoftQuantumIntrinsicX.Apply(outputQubit);
#line 20 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
                    MicrosoftQuantumIntrinsicH.Apply(outputQubit);
#line 22 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
                    MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicX, inputQubits?.Slice(new Range(((2L < 0L) ? (inputQubits.Length - 1L) : 0L), 2L, ((2L < 0L) ? 0L : (inputQubits.Length - 1L))))));
#line 27 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((inputQubits, outputQubit));
#line hidden
                    MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumIntrinsicX, inputQubits?.Slice(new Range(((2L < 0L) ? (inputQubits.Length - 1L) : 0L), 2L, ((2L < 0L) ? 0L : (inputQubits.Length - 1L))))));
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Apply(outputQubit);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(outputQubit);
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
                    Release.Apply(outputQubit);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<ReflectAboutMarked, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    public partial class ReflectAboutUniform : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectAboutUniform(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutUniform";
        String ICallable.FullName => "qsBell.Bell.ReflectAboutUniform";
        protected IUnitary<IQArray<Qubit>> PrepareAllOnes
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> PrepareUniform
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ReflectAboutAllOnes
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var inputQubits = __in__;
#line 38 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
            PrepareUniform.Adjoint.Apply(inputQubits);
#line 40 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
            PrepareAllOnes.Apply(inputQubits);
#line 45 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
            ReflectAboutAllOnes.Apply(inputQubits);
#line hidden
            PrepareAllOnes.Adjoint.Apply(inputQubits);
#line hidden
            PrepareUniform.Adjoint.Adjoint.Apply(inputQubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PrepareAllOnes = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(PrepareAllOnes));
            this.PrepareUniform = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(PrepareUniform));
            this.ReflectAboutAllOnes = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ReflectAboutAllOnes));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<ReflectAboutUniform, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    public partial class ReflectAboutAllOnes : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectAboutAllOnes(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutAllOnes";
        String ICallable.FullName => "qsBell.Bell.ReflectAboutAllOnes";
        protected ICallable MicrosoftQuantumArraysMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysTail
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var inputQubits = __in__;
#line 52 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(inputQubits), MicrosoftQuantumArraysTail.Apply<Qubit>(inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Most<>));
            this.MicrosoftQuantumArraysTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Tail<>));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<ReflectAboutAllOnes, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    public partial class PrepareUniform : Unitary<IQArray<Qubit>>, ICallable
    {
        public PrepareUniform(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareUniform";
        String ICallable.FullName => "qsBell.Bell.PrepareUniform";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var inputQubits = __in__;
#line 58 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var inputQubits = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicH, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<PrepareUniform, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    public partial class PrepareAllOnes : Unitary<IQArray<Qubit>>, ICallable
    {
        public PrepareAllOnes(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareAllOnes";
        String ICallable.FullName => "qsBell.Bell.PrepareAllOnes";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var inputQubits = __in__;
#line 64 "C:/Users/Telahun/Documents/School/Q/GroversAlgorithmQSvsQiskit/Qsharp/qsBell/Bell/Reflections.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicX, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var inputQubits = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicX, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicX, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<PrepareAllOnes, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }
}