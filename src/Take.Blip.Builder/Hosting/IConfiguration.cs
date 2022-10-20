﻿using System;

namespace Take.Blip.Builder.Hosting
{
    public interface IConfiguration
    {
        TimeSpan InputProcessingTimeout { get; }

        /// <summary>
        /// The input processing timeout after semaphore.
        /// </summary>
        TimeSpan InputProcessingTimeoutAfterSemaphore { get; }

        int RedisDatabase { get; }

        string RedisKeyPrefix { get; }

        int MaxTransitionsByInput { get; }

        int TraceQueueBoundedCapacity { get; }

        int TraceQueueMaxDegreeOfParallelism { get; }

        TimeSpan TraceTimeout { get; }
        
        TimeSpan DefaultActionExecutionTimeout { get; }

        int ExecuteScriptLimitRecursion { get; }

        int ExecuteScriptMaxStatements { get; }

        long ExecuteScriptLimitMemory { get; }

        long ExecuteScriptLimitMemoryWarning { get; }

        TimeSpan ExecuteScriptTimeout { get; }
    }
}