﻿using gameStore.Models.Rerository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using System.Web.UI;

namespace gameStore.Controllers
{
    public partial class CategoryList : UserControl
    {
        protected IEnumerable<string> GetCategories()
        {
            return new Repository().Categories
                .Select(p => p.CategoryName)
                .Distinct()
                .OrderBy(x => x);
        }
        protected string CreateHomeLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null, null).VirtualPath;

            return string.Format("<a href='{0}'>Главная</a>", path);
        }
        protected string CreateLinkHtml(string category)
        {
            string selectedCategory = (string)Page.RouteData.Values["category"] ?? Request.QueryString["category"];

            string path = RouteTable.Routes.GetVirtualPath(null, null,
                new RouteValueDictionary() { { "category", category },
                    {"page", "1"} }).VirtualPath;

            return string.Format("<a href='{0}' {1}>{2}</a>", path, category == selectedCategory ? "class='selected'" : "", category);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}