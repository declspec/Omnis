﻿using System;
using System.Collections;
using System.Collections.Generic;
using Omnis.Web;
using Microsoft.AspNetCore.Http;

namespace OmnisCore.Web.Internal {
    public class OmnisCoreHttpRequestCookies : IHttpRequestCookies {
        private readonly IRequestCookieCollection _cookies;

        public string this[string key] => _cookies[key];
        public int Count => _cookies.Count;
        public ICollection<string> Keys => _cookies.Keys;

        public OmnisCoreHttpRequestCookies(IRequestCookieCollection cookies) {
            _cookies = cookies ?? throw new ArgumentNullException(nameof(cookies));
        }

        public bool ContainsKey(string key) => _cookies.ContainsKey(key);
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => _cookies.GetEnumerator();
        public bool TryGetValue(string key, out string value) => _cookies.TryGetValue(key, out value);
        IEnumerator IEnumerable.GetEnumerator() => _cookies.GetEnumerator();
    }
}
