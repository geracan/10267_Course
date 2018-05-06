<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ImportCountries.aspx.cs" Inherits="ImportCountries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <asp:XmlDataSource ID="CountriesXmlDataSource" runat="server" DataFile="~/Countries.xml">
    </asp:XmlDataSource>
    <div class="importCountriesHeader">
        <asp:Button ID="FilterButton" runat="server" Text="Filter Countries" OnClick="FilterButton_Click" />
        <asp:Button ID="SaveButton" runat="server" Text="Save Countries" 
            onclick="SaveButton_Click" />
    </div>
    <div class="importResult">
        <asp:Label ID="ImportResultLabel" runat="server" EnableViewState="false"></asp:Label>
    </div>
    <asp:GridView ID="CountriesGridView" runat="server" DataSourceID="CountriesXmlDataSource"
        Width="100%">
    </asp:GridView>
</asp:Content>
