/* 
XML-RPC.NET library
Copyright (c) 2001-2006, Charles Cook <charlescook@cookcomputing.com>

Permission is hereby granted, free of charge, to any person 
obtaining a copy of this software and associated documentation 
files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, 
publish, distribute, sublicense, and/or sell copies of the Software, 
and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be 
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/

using System;
using System.IO;

namespace CookComputing.XmlRpc
{
    public class XmlRpcHttpResponse : IHttpResponse
    {
        public XmlRpcHttpResponse(System.Web.HttpResponse response)
        {
            _resp = response;
        }

        string IHttpResponse.ContentType { 
            get { return _resp.ContentType; } 
            set { _resp.ContentType = value; } 
        }

        TextWriter IHttpResponse.Output {
            get { return _resp.Output; }
        }

        Stream IHttpResponse.OutputStream {
            get { return _resp.OutputStream; }
        }

        bool IHttpResponse.SendChunked {
            get { return true; }
            set { throw new NotImplementedException(); }
        }

        int IHttpResponse.StatusCode { 
            get { return _resp.StatusCode; } 
            set { _resp.StatusCode = value; } 
        }

        string IHttpResponse.StatusDescription { 
            get { return _resp.StatusDescription; } 
            set { _resp.StatusDescription = value; } 
        }

        Int64 IHttpResponse.ContentLength {
            set { throw new NotImplementedException(); }
        }

        private System.Web.HttpResponse _resp;
    }
}
