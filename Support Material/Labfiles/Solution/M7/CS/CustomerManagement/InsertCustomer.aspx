<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="InsertCustomer.aspx.cs" Inherits="InsertCustomer" %>

<%@ Register src="Customer.ascx" tagname="Customer" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" Runat="Server">
    <uc1:Customer ID="Customer1" runat="server" />
</asp:Content>

