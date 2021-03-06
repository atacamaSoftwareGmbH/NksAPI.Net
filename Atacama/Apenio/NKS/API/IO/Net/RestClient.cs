﻿/// Copyright (c) 2017 atacama | Software GmbH
/// 
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
using NksAPI.Atacama.Apenio.NKS.API.IO;
using NksAPI.Atacama.Apenio.NKS.API.IO.Net;
using System.Threading.Tasks;

namespace Atacama.Apenio.NKS.API.IO.Net
{
    internal class RestClient
    {
        private static readonly RestClient instance = new RestClient();
        public static RestClient Instance { get { return instance; } }

        private RestClient() { }

        internal async Task<NksResponse> Post(NksQuery query, string url)
        {
            NksResponse result = null;
            result = await HttpUtil.Post(url, query);
            return result;
        }

        internal async Task<NksResponse> Get(string url)
        {
            NksResponse result = null;
            result = await HttpUtil.Get(url);
            return result;
        }
    }
}