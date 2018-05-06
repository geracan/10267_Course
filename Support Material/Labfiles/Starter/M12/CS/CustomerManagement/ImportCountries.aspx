<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ImportCountries.aspx.cs" Inherits="ImportCountries" %>

<asp:Content ID="ImportCountriesContent" ContentPlaceHolderID="MainContentPlaceHolder"
    runat="Server">
    <asp:ScriptManagerProxy runat="server" ID="ImportCountriesScriptManagerProxy" />
    <asp:UpdateProgress ID="ImportCountriesUpdateProgress" runat="server" AssociatedUpdatePanelID="ImportCountriesUpdatePanel"
        DisplayAfter="0">
        <ProgressTemplate>
            Processing...
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel ID="ImportCountriesUpdatePanel" runat="server">
        <ContentTemplate>
            <asp:XmlDataSource ID="CountriesXmlDataSource" runat="server" DataFile="~/Countries.xml">
            </asp:XmlDataSource>
            <div class="importCountriesHeader">
                <asp:Button ID="FilterButton" runat="server" Text="Filter Countries" OnClick="FilterButton_Click" />
                <asp:Button ID="SaveButton" runat="server" Text="Save Countries" OnClick="SaveButton_Click" />
            </div>
            <div class="importResult">
                <asp:Label ID="ImportResultLabel" runat="server" EnableViewState="false"></asp:Label>
            </div>
            <asp:GridView ID="CountriesGridView" runat="server" DataSourceID="CountriesXmlDataSource"
                Width="100%">
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
