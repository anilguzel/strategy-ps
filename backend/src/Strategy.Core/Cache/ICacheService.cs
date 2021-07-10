﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Core.Cache
{
    public interface ICacheService
    {
        T Get<T>(string key);

        object Set(string key, object value, DateTimeOffset? absoluteExpiration = null, TimeSpan? slidingExpiration = null);

        void Clear(string key);

        List<T> GetList<T>(string key)
            where T : class;
    }
}
