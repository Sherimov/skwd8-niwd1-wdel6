﻿using ServerEntities;

using System;
using System.Collections.Generic;
using System.Text;

namespace ServerCore.Engine
{
    public class ServerEngine
    {
        public static Response Process(Request request)
        {
            var parsedUri = UriParser.Parse(request.Uri);
            var message = "Hello Server World";
            return new Response
            {
                // Doesn't make sense, but nice first approximation
                Headers = request.Headers,
                Version = request.Version,
                Message = message,
                Status = 200,
                Body = $"<h1>HELLO FROM SEDC SERVER {DateTime.Now.ToLongTimeString()}</h1>"
            };
        }
    }
}
