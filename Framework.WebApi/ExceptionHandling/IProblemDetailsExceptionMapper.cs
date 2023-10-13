namespace Framework.ExceptionHandling;

public interface IProblemDetailsExceptionMapper
{
    bool TryGetMapping(Type exceptionType, out ExceptionMapping mapping);
}