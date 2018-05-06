<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsertCustomer.aspx.cs" Inherits="InsertCustomer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body class="template">
    <form id="form1" runat="server">
    <div class="customertable">
        <div class="customertablerow">
            <div class="customertableleftcol">
                <asp:Label ID="CustomerNameLabel" runat="server" Text="Name:"></asp:Label>
            </div>
            <div class="customertablerightcol">
                <asp:TextBox ID="CustomerNameTextBox" runat="server" MaxLength="50"></asp:TextBox>
            </div>
        </div>
        <div class="customertablerow">
            <div class="customertableleftcol">
                <asp:Label ID="CustomerAddressLabel" runat="server" Text="Address:"></asp:Label>
            </div>
            <div class="customertablerightcol">
                <asp:TextBox ID="CustomerAddressTextBox" runat="server" MaxLength="50"></asp:TextBox>
            </div>
        </div>
        <div class="customertablerow">
            <div class="customertableleftcol">
                <asp:Label ID="CustomerPhoneLabel" runat="server" Text="Phone:"></asp:Label>
            </div>
            <div class="customertablerightcol">
                <asp:TextBox ID="CustomerPhoneTextBox" runat="server" MaxLength="30"></asp:TextBox>
            </div>
        </div>
        <div class="customertablerow">
            <div class="customertableleftcol">
                <asp:Label ID="CustomerZipCodeLabel" runat="server" Text="Zip Code:"></asp:Label>
            </div>
            <div class="customertablerightcol">
                <asp:TextBox ID="CustomerZipCodeTextBox" runat="server" MaxLength="10"></asp:TextBox>
            </div>
        </div>
        <div class="customertablerow">
            <div class="customertableleftcol">
                <asp:Label ID="CustomerCityLabel" runat="server" Text="City:"></asp:Label>
            </div>
            <div class="customertablerightcol">
                <asp:TextBox ID="CustomerCityTextBox" runat="server" MaxLength="30"></asp:TextBox>
            </div>
        </div>
        <div class="customertablerow">
            <div class="customertableleftcol">
                <asp:Label ID="CustomerStateLabel" runat="server" Text="State:"></asp:Label>
            </div>
            <div class="customertablerightcol">
                <asp:TextBox ID="CustomerStateTextBox" runat="server" MaxLength="30"></asp:TextBox>
            </div>
        </div>
        <div class="customertablerow">
            <div class="customertableleftcol">
                <asp:Label ID="CustomerEmailAddressLabel" runat="server" Text="Email Address:"></asp:Label>
            </div>
            <div class="customertablerightcol">
                <asp:TextBox ID="CustomerEmailAddressTextBox" runat="server" MaxLength="40"></asp:TextBox>
            </div>
        </div>
        <div class="customertablefooter">
            <asp:Button ID="CustomerInsertButton" runat="server" Text="Insert" 
                onclick="CustomerInsertButton_Click" />
            &nbsp;<asp:Button ID="CustomerCancelButton" runat="server" Text="Cancel" 
                onclick="CustomerCancelButton_Click" />
        </div>
    </div>
    </form>
</body>
</html>
