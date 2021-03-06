﻿using System;

namespace NeoClient.Extensions
{
    public static class DateTimeExtensions
    {
        internal static double ToTimeStamp(this DateTime source)
        {
            return (source - new DateTime(1970, 1, 1)).TotalMilliseconds;
        }
    }
}
