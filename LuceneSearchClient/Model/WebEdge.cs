﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;

namespace LuceneSearchClient.Model
{
    public class WebEdge:Edge<WebVertex>
    {
        public string SourceTarget { get; set; }
        public WebEdge(WebVertex source, WebVertex target) : base(source, target)
        {
            SourceTarget = source.Label + "*" + target.Label;
        }
    }
}
