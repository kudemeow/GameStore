<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.ascx.cs" Inherits="gameStore.Controllers.CategoryList" %>
<%= CreateHomeLinkHtml() %>

<% foreach (string category in GetCategories()) { // CreateLinkHtml - ссылка на страницу
       Response.Write(CreateLinkHtml(category));       
   }
%>