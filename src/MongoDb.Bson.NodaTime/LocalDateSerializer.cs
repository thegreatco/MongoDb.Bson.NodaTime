﻿using NodaTime;
using NodaTime.Text;

namespace MongoDb.Bson.NodaTime
{
    public class LocalDateSerializer : PatternSerializer<LocalDate>
    {
        public LocalDateSerializer() : base(LocalDatePattern.IsoPattern, d => d.WithCalendar(CalendarSystem.Iso))
        {}
    }
}