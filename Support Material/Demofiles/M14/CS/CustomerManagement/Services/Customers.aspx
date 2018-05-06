<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Services_Customers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Countries by Contoso</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="StartingLettersLabel" runat="server" Text="Starting letters of countries to return:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="StartingLettersTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="StartingLettersRequiredFieldValidator" runat="server"
            ErrorMessage="The text box must contain at least one character." ControlToValidate="StartingLettersTextBox"
            Display="Dynamic"></asp:RequiredFieldValidator>
        &nbsp;
        <asp:Button ID="GetCountriesButton" runat="server" OnClick="GetCountriesButton_Click"
            Text="Get Countries" />
        <br />
        <asp:GridView ID="CustomersGridView" runat="server" CssClass="DDGridView">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
