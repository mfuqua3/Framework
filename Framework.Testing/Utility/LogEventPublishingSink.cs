using Serilog.Core;
using Serilog.Events;

namespace Framework.Testing.Utility;

public class LogEventPublishingSink : ILogEventSink
{
    public event EventHandler<EventArgs> EventEmitted;

    void ILogEventSink.Emit(LogEvent logEvent)
        => EventEmitted?.Invoke(this, new EventArgs(logEvent));

    public class EventArgs : System.EventArgs
    {
        public LogEvent Event { get; }

        public EventArgs(LogEvent @event)
        {
            Event = @event;
        }
    }
}