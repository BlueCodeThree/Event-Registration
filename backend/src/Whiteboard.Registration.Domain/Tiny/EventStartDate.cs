using System;

namespace Whiteboard.Registration.Domain.Tiny
{
    public class EventStartDate : TinyType<DateTime>
    {
        public EventStartDate(DateTime value) : base(value)
        {
        }
    }
}
