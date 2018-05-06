<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="InsertCustomer.aspx.cs" Inherits="InsertCustomer" %>

<%@ Register Src="Customer.ascx" TagName="Customer" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <uc1:Customer ID="Customer1" runat="server" />
</asp:Content>
