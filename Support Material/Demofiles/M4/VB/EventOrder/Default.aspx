﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" EnableViewState="False" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body class="template">
    <form id="form1" runat="server">
    <div class="eventordertable">
        <div class="eventordertableleftcol">
            <b>
                <asp:Label ID="Label1" runat="server" Text="Non-Postback Events" /></b>
            <br />
            <br />
            <asp:Label ID="NonPostBackEventLabel" runat="server" Text="" />
            <br />
            <br />
        </div>
        <div class="eventordertablerightcol">
            <b>
                <asp:Label ID="Label2" runat="server" Text="Postback Events" /></b>
            <br />
            <br />
            <asp:Label ID="PostBackEventLabel" runat="server" Text="" />
            <br />
            <br />
        </div>
        <div class="eventordertablefooter">
            <asp:Button ID="PostbackButton" runat="server" Text="Postback" />
        </div>
    </div>
    </form>
</body>
</html>
