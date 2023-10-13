using System.Runtime.Serialization;

namespace Framework.Testing.TestingComponents.Infrastructure;
[Serializable]
public class TestResourceAccessException :Exception
{
    public TestResourceAccessException(string message):base(message)
    {
        
    }

    protected TestResourceAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        
    }
}