﻿using System;
using System.Net;

namespace W3S_GCS.Models.Search {
    public class SearchResponse {
        public Boolean Success { get; set; }
        public String Response { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}