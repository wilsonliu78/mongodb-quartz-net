﻿using System;

namespace Quartz.Spi.MongoDbJobStore.Models
{
    internal class SimpleTrigger : Trigger
    {
        public SimpleTrigger()
        {
        }

        public SimpleTrigger(ISimpleTrigger trigger, TriggerState state) : base(trigger, state)
        {
            RepeatCount = trigger.RepeatCount;
            RepeatInterval = trigger.RepeatInterval;
            TimesTriggered = trigger.TimesTriggered;
        }

        public int RepeatCount { get; set; }

        public TimeSpan RepeatInterval { get; set; }

        public int TimesTriggered { get; set; }
    }
}