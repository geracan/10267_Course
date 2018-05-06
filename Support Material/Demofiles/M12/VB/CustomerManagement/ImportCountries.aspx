<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false"
    CodeFile="ImportCountries.aspx.vb" Inherits="ImportCountries" %>

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
                <asp:Button ID="FilterButton" runat="server" Text="Filter Countries" />
                <asp:Button ID="SaveButton" runat="server" Text="Save Countries" />
            </div>
            <div class="importResult">
                <asp:Label ID="ImportResultLabel" runat="server" EnableViewState="false"></asp:Label>
            </div>
            <asp:GridView ID="CountriesGridView" runat="server" AutoGenerateColumns="False" DataSourceID="CountriesXmlDataSource"
                Width="100%">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="PhoneNoFormat" HeaderText="PhoneNoFormat" SortExpression="PhoneNoFormat" />
                    <asp:BoundField DataField="DialingCountryCode" HeaderText="DialingCountryCode" SortExpression="DialingCountryCode" />
                    <asp:BoundField DataField="InternationalDialingCode" HeaderText="InternationalDialingCode"
                        SortExpression="InternationalDialingCode" />
                    <asp:BoundField DataField="InternetTLD" HeaderText="InternetTLD" SortExpression="InternetTLD" />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
