<%@ Page Title="Order Entry" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeFile="Order.aspx.cs" Inherits="Order" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="orderTable">
        <div class="orderTableRow">
            <div class="orderTableLeftCol">
                <asp:Label ID="OrderDateLabel" runat="server" Text="Order Date:"></asp:Label>
            </div>
            <div class="orderTableRightCol">
                <asp:TextBox ID="OrderDateTextBox" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
        </div>
        <div class="orderTableRow">
            <div class="orderTableLeftCol">
                <asp:Label ID="DueDateLabel" runat="server" Text="Due Date:"></asp:Label>
            </div>
            <div class="orderTableRightCol">
                <asp:TextBox ID="DueDateTextBox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="orderTableRow">
            <div class="orderTableLeftCol">
                <asp:Label ID="ShipDateLabel" runat="server" Text="Ship Date:"></asp:Label>
            </div>
            <div class="orderTableRightCol">
                <asp:TextBox ID="ShipDateTextBox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="orderTableRow">
            <div class="orderTableLeftCol">
                <asp:Label ID="SalesOrderNumberLabel" runat="server" Text="Sales Order Number:"></asp:Label>
            </div>
            <div class="orderTableRightCol">
                <asp:TextBox ID="SalesOrderNumberTextBox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="orderTableRow">
            <div class="orderTableLeftCol">
                <asp:Label ID="PurchaseOrderLabel" runat="server" Text="Purchase Order:"></asp:Label>
            </div>
            <div class="orderTableRightCol">
                <asp:TextBox ID="PurchaseOrderTextBox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="orderTableRow">
            <div class="orderTableLeftCol">
                <asp:Label ID="AccountNumberLabel" runat="server" Text="Account Number:"></asp:Label>
            </div>
            <div class="orderTableRightCol">
                <asp:TextBox ID="AccountNumberTextBox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="orderTableRow">
            <div class="orderTableLeftCol">
                <asp:Label ID="CustomerCountryLabel" runat="server" Text="Country:"></asp:Label>
            </div>
            <div class="orderTableRightCol">
                <asp:DropDownList ID="CustomerCountryDropDownList" runat="server">
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>United Kingdom</asp:ListItem>
                    <asp:ListItem>Denmark</asp:ListItem>
                    <asp:ListItem>Spain</asp:ListItem>
                    <asp:ListItem>Rep. of Ireland</asp:ListItem>
                    <asp:ListItem>India</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="orderTableRow">
            <div class="orderTableLeftCol">
                <asp:Label ID="CustomerEmailAddressLabel" runat="server" Text="Email Address:"></asp:Label>
            </div>
            <div class="orderTableRightCol">
                <asp:TextBox ID="CustomerEmailAddressTextBox" runat="server" MaxLength="50"></asp:TextBox>
            </div>
        </div>
        <div class="orderTableFooter">
            <asp:Button ID="OrderSaveButton" runat="server" Text="Save" OnClick="OrderSaveButton_Click" />
            &nbsp;<asp:Button ID="OrderCancelButton" runat="server" Text="Cancel" OnClick="OrderCancelButton_Click" />
        </div>
    </div>
</asp:Content>