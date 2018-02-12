/// Copyright (c) 2017 atacama | Software GmbH
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
using System.Net;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.IO.Net
{
    internal static class HttpUtil
    {
        internal static HttpClient http = new HttpClient();
       

        internal static async Task<NksResponse> Post(string url, NksQuery data)
        {
            NksResponse responseObject = null;
            http.DefaultRequestHeaders.Clear();
            http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await http.PostAsJsonAsync(url, data);
            if (response.IsSuccessStatusCode)
            {
                responseObject = await response.Content.ReadAsAsync<NksResponse>();
            }
            return responseObject;
        }

        internal static async Task<NksResponse> Get(string url)
        {
            NksResponse responseObject = null;
            http.DefaultRequestHeaders.Clear();
            http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await http.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                responseObject = await response.Content.ReadAsAsync<NksResponse>();
            }
            return responseObject;
        }
    }
}
