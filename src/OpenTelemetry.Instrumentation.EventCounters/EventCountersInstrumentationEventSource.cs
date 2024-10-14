// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

using System.Diagnostics.Tracing;
using Microsoft.Extensions.Configuration;

namespace OpenTelemetry.Instrumentation.EventCounters;

/// <summary>
/// EventSource events emitted from the project.
/// </summary>
[EventSource(Name = "OpenTelemetry-Instrumentation-EventCounters")]
internal sealed class EventCountersInstrumentationEventSource : EventSource, IConfigurationExtensionsLogger
{
    public static readonly EventCountersInstrumentationEventSource Log = new();

    void IConfigurationExtensionsLogger.LogInvalidConfigurationValue(string key, string value)
    {
        this.InvalidConfigurationValue(key, value);
    }

    [Event(1, Level = EventLevel.Warning, Message = "Error while writing event from source: {0} - {1}.")]
    internal void ErrorWhileWritingEvent(string eventSourceName, string exceptionMessage)
    {
        this.WriteEvent(1, eventSourceName, exceptionMessage);
    }

    [Event(2, Level = EventLevel.Warning, Message = "Event data payload not parsable from source: {0}.")]
    internal void IgnoreEventWrittenEventArgsPayloadNotParsable(string eventSourceName)
    {
        this.WriteEvent(2, eventSourceName);
    }

    [Event(3, Level = EventLevel.Warning, Message = "Event data has no name from source: {0}.")]
    internal void IgnoreEventWrittenEventArgsWithoutName(string eventSourceName)
    {
        this.WriteEvent(3, eventSourceName);
    }

    [Event(4, Level = EventLevel.Warning, Message = "Event data payload problem with values of Mean, Increment from source: {0}.")]
    internal void IgnoreMeanIncrementConflict(string eventSourceName)
    {
        this.WriteEvent(4, eventSourceName);
    }

    [Event(5, Level = EventLevel.Warning, Message = "Event data has name other than 'EventCounters' from source: {0}.")]
    internal void IgnoreNonEventCountersName(string eventSourceName)
    {
        this.WriteEvent(5, eventSourceName);
    }

    [Event(6, Level = EventLevel.Warning, Message = "Configuration key '{0}' has an invalid value: '{1}'")]
    internal void InvalidConfigurationValue(string key, string value)
    {
        this.WriteEvent(6, key, value);
    }
}
