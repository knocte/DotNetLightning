namespace ResultUtils.Portability

#if NoDUsAsStructs
[<StructuralEquality; StructuralComparison>]
[<CompiledName("FSharpResult`2")>]
type Result<'T,'TError> =
    | Ok of ResultValue: 'T
    | Error of ErrorValue: 'TError

#else

type Result<'T, 'TError> = FSharp.Core.Result<'T, 'TError>

#endif

