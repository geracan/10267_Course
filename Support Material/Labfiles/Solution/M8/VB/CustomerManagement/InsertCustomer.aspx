<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="InsertCustomer.aspx.vb" Inherits="InsertCustomer" %>

<%@ Register src="Customer.ascx" tagname="Customer" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" Runat="Server">
    <uc1:Customer ID="Customer1" runat="server" />
</asp:Content>

