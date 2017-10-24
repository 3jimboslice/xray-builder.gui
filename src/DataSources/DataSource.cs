﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace XRayBuilderGUI.DataSources
{
    public abstract class DataSource
    {
        public abstract string Name { get; }
        public virtual HtmlDocument sourceHtmlDoc { get; set; }
        public abstract Task<string> SearchBook(string author, string title);
        public abstract Task<BookInfo> GetNextInSeries(BookInfo curBook, AuthorProfile authorProfile, string TLD);
        public virtual Task<bool> GetPageCount(BookInfo curBook) { return Task.FromResult(false); }
        public virtual Task GetExtras(BookInfo curBook, CancellationToken token, IProgress<Tuple<int, int>> progress = null) { return Task.FromResult(false); }
        public virtual Task<List<XRay.Term>> GetTerms(string dataUrl, IProgress<Tuple<int, int>> progress, CancellationToken token) { return Task.FromResult(new List<XRay.Term>()); }
        public virtual Task<List<Tuple<string, int>>> GetNotableClips(string url, CancellationToken token, HtmlDocument srcDoc = null, IProgress<Tuple<int, int>> progress = null) { return Task.FromResult(new List<Tuple<string, int>>()); }
    }
}
