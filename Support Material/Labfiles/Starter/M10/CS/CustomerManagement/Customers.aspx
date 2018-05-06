<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" Runat="Server">
    <asp:SqlDataSource ID="CustomersSqlDataSource" runat="server" 
        ConflictDetection="CompareAllValues" 
        ConnectionString="<%$ ConnectionStrings:CustomerManagementConnectionString %>" 
        DeleteCommand="DELETE FROM [Customers] WHERE [ID] = @original_ID AND [FirstName] = @original_FirstName AND [LastName] = @original_LastName AND [Address] = @original_Address AND (([Phone] = @original_Phone) OR ([Phone] IS NULL AND @original_Phone IS NULL)) AND [ZipCode] = @original_ZipCode AND [City] = @original_City AND (([State] = @original_State) OR ([State] IS NULL AND @original_State IS NULL)) AND [CountryID] = @original_CountryID AND (([EmailAddress] = @original_EmailAddress) OR ([EmailAddress] IS NULL AND @original_EmailAddress IS NULL)) AND [Url] = @original_Url AND [CreditLimit] = @original_CreditLimit AND [CreatedDate] = @original_CreatedDate AND [CreatedBy] = @original_CreatedBy AND (([ModifiedDate] = @original_ModifiedDate) OR ([ModifiedDate] IS NULL AND @original_ModifiedDate IS NULL)) AND (([ModifiedBy] = @original_ModifiedBy) OR ([ModifiedBy] IS NULL AND @original_ModifiedBy IS NULL))" 
        InsertCommand="INSERT INTO [Customers] ([ID], [FirstName], [LastName], [Address], [Phone], [ZipCode], [City], [State], [CountryID], [EmailAddress], [Url], [CreditLimit], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (@ID, @FirstName, @LastName, @Address, @Phone, @ZipCode, @City, @State, @CountryID, @EmailAddress, @Url, @CreditLimit, @CreatedDate, @CreatedBy, @ModifiedDate, @ModifiedBy)" 
        OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT * FROM [Customers]" 
        UpdateCommand="UPDATE [Customers] SET [FirstName] = @FirstName, [LastName] = @LastName, [Address] = @Address, [Phone] = @Phone, [ZipCode] = @ZipCode, [City] = @City, [State] = @State, [CountryID] = @CountryID, [EmailAddress] = @EmailAddress, [Url] = @Url, [CreditLimit] = @CreditLimit, [CreatedDate] = @CreatedDate, [CreatedBy] = @CreatedBy, [ModifiedDate] = @ModifiedDate, [ModifiedBy] = @ModifiedBy WHERE [ID] = @original_ID AND [FirstName] = @original_FirstName AND [LastName] = @original_LastName AND [Address] = @original_Address AND (([Phone] = @original_Phone) OR ([Phone] IS NULL AND @original_Phone IS NULL)) AND [ZipCode] = @original_ZipCode AND [City] = @original_City AND (([State] = @original_State) OR ([State] IS NULL AND @original_State IS NULL)) AND [CountryID] = @original_CountryID AND (([EmailAddress] = @original_EmailAddress) OR ([EmailAddress] IS NULL AND @original_EmailAddress IS NULL)) AND [Url] = @original_Url AND [CreditLimit] = @original_CreditLimit AND [CreatedDate] = @original_CreatedDate AND [CreatedBy] = @original_CreatedBy AND (([ModifiedDate] = @original_ModifiedDate) OR ([ModifiedDate] IS NULL AND @original_ModifiedDate IS NULL)) AND (([ModifiedBy] = @original_ModifiedBy) OR ([ModifiedBy] IS NULL AND @original_ModifiedBy IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_ID" Type="Object" />
            <asp:Parameter Name="original_FirstName" Type="String" />
            <asp:Parameter Name="original_LastName" Type="String" />
            <asp:Parameter Name="original_Address" Type="String" />
            <asp:Parameter Name="original_Phone" Type="String" />
            <asp:Parameter Name="original_ZipCode" Type="String" />
            <asp:Parameter Name="original_City" Type="String" />
            <asp:Parameter Name="original_State" Type="String" />
            <asp:Parameter Name="original_CountryID" Type="Object" />
            <asp:Parameter Name="original_EmailAddress" Type="String" />
            <asp:Parameter Name="original_Url" Type="String" />
            <asp:Parameter Name="original_CreditLimit" Type="Int32" />
            <asp:Parameter Name="original_CreatedDate" Type="DateTime" />
            <asp:Parameter Name="original_CreatedBy" Type="String" />
            <asp:Parameter Name="original_ModifiedDate" Type="DateTime" />
            <asp:Parameter Name="original_ModifiedBy" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ID" Type="Object" />
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
            <asp:Parameter Name="ZipCode" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="State" Type="String" />
            <asp:Parameter Name="CountryID" Type="Object" />
            <asp:Parameter Name="EmailAddress" Type="String" />
            <asp:Parameter Name="Url" Type="String" />
            <asp:Parameter Name="CreditLimit" Type="Int32" />
            <asp:Parameter Name="CreatedDate" Type="DateTime" />
            <asp:Parameter Name="CreatedBy" Type="String" />
            <asp:Parameter Name="ModifiedDate" Type="DateTime" />
            <asp:Parameter Name="ModifiedBy" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
            <asp:Parameter Name="ZipCode" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="State" Type="String" />
            <asp:Parameter Name="CountryID" Type="Object" />
            <asp:Parameter Name="EmailAddress" Type="String" />
            <asp:Parameter Name="Url" Type="String" />
            <asp:Parameter Name="CreditLimit" Type="Int32" />
            <asp:Parameter Name="CreatedDate" Type="DateTime" />
            <asp:Parameter Name="CreatedBy" Type="String" />
            <asp:Parameter Name="ModifiedDate" Type="DateTime" />
            <asp:Parameter Name="ModifiedBy" Type="String" />
            <asp:Parameter Name="original_ID" Type="Object" />
            <asp:Parameter Name="original_FirstName" Type="String" />
            <asp:Parameter Name="original_LastName" Type="String" />
            <asp:Parameter Name="original_Address" Type="String" />
            <asp:Parameter Name="original_Phone" Type="String" />
            <asp:Parameter Name="original_ZipCode" Type="String" />
            <asp:Parameter Name="original_City" Type="String" />
            <asp:Parameter Name="original_State" Type="String" />
            <asp:Parameter Name="original_CountryID" Type="Object" />
            <asp:Parameter Name="original_EmailAddress" Type="String" />
            <asp:Parameter Name="original_Url" Type="String" />
            <asp:Parameter Name="original_CreditLimit" Type="Int32" />
            <asp:Parameter Name="original_CreatedDate" Type="DateTime" />
            <asp:Parameter Name="original_CreatedBy" Type="String" />
            <asp:Parameter Name="original_ModifiedDate" Type="DateTime" />
            <asp:Parameter Name="original_ModifiedBy" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:ListView ID="CustomersListView" runat="server" DataKeyNames="ID" 
        DataSourceID="CustomersSqlDataSource">
        <AlternatingItemTemplate>
            <tr style="">
                <td>
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                </td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                </td>
                <td>
                    <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                </td>
                <td>
                    <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
                </td>
                <td>
                    <asp:Label ID="ZipCodeLabel" runat="server" Text='<%# Eval("ZipCode") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="StateLabel" runat="server" Text='<%# Eval("State") %>' />
                </td>
                <td>
                    <asp:Label ID="CountryIDLabel" runat="server" Text='<%# Eval("CountryID") %>' />
                </td>
                <td>
                    <asp:Label ID="EmailAddressLabel" runat="server" 
                        Text='<%# Eval("EmailAddress") %>' />
                </td>
                <td>
                    <asp:Label ID="UrlLabel" runat="server" Text='<%# Eval("Url") %>' />
                </td>
                <td>
                    <asp:Label ID="CreditLimitLabel" runat="server" 
                        Text='<%# Eval("CreditLimit") %>' />
                </td>
                <td>
                    <asp:Label ID="CreatedDateLabel" runat="server" 
                        Text='<%# Eval("CreatedDate") %>' />
                </td>
                <td>
                    <asp:Label ID="CreatedByLabel" runat="server" Text='<%# Eval("CreatedBy") %>' />
                </td>
                <td>
                    <asp:Label ID="ModifiedDateLabel" runat="server" 
                        Text='<%# Eval("ModifiedDate") %>' />
                </td>
                <td>
                    <asp:Label ID="ModifiedByLabel" runat="server" 
                        Text='<%# Eval("ModifiedBy") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                        Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Cancel" />
                </td>
                <td>
                    <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="FirstNameTextBox" runat="server" 
                        Text='<%# Bind("FirstName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="LastNameTextBox" runat="server" 
                        Text='<%# Bind("LastName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ZipCodeTextBox" runat="server" Text='<%# Bind("ZipCode") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StateTextBox" runat="server" Text='<%# Bind("State") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CountryIDTextBox" runat="server" 
                        Text='<%# Bind("CountryID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="EmailAddressTextBox" runat="server" 
                        Text='<%# Bind("EmailAddress") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UrlTextBox" runat="server" Text='<%# Bind("Url") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CreditLimitTextBox" runat="server" 
                        Text='<%# Bind("CreditLimit") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CreatedDateTextBox" runat="server" 
                        Text='<%# Bind("CreatedDate") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CreatedByTextBox" runat="server" 
                        Text='<%# Bind("CreatedBy") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ModifiedDateTextBox" runat="server" 
                        Text='<%# Bind("ModifiedDate") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ModifiedByTextBox" runat="server" 
                        Text='<%# Bind("ModifiedBy") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>
                        No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                        Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Clear" />
                </td>
                <td>
                    <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="FirstNameTextBox" runat="server" 
                        Text='<%# Bind("FirstName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="LastNameTextBox" runat="server" 
                        Text='<%# Bind("LastName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ZipCodeTextBox" runat="server" Text='<%# Bind("ZipCode") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StateTextBox" runat="server" Text='<%# Bind("State") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CountryIDTextBox" runat="server" 
                        Text='<%# Bind("CountryID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="EmailAddressTextBox" runat="server" 
                        Text='<%# Bind("EmailAddress") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UrlTextBox" runat="server" Text='<%# Bind("Url") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CreditLimitTextBox" runat="server" 
                        Text='<%# Bind("CreditLimit") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CreatedDateTextBox" runat="server" 
                        Text='<%# Bind("CreatedDate") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CreatedByTextBox" runat="server" 
                        Text='<%# Bind("CreatedBy") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ModifiedDateTextBox" runat="server" 
                        Text='<%# Bind("ModifiedDate") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ModifiedByTextBox" runat="server" 
                        Text='<%# Bind("ModifiedBy") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="">
                <td>
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                </td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                </td>
                <td>
                    <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                </td>
                <td>
                    <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
                </td>
                <td>
                    <asp:Label ID="ZipCodeLabel" runat="server" Text='<%# Eval("ZipCode") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="StateLabel" runat="server" Text='<%# Eval("State") %>' />
                </td>
                <td>
                    <asp:Label ID="CountryIDLabel" runat="server" Text='<%# Eval("CountryID") %>' />
                </td>
                <td>
                    <asp:Label ID="EmailAddressLabel" runat="server" 
                        Text='<%# Eval("EmailAddress") %>' />
                </td>
                <td>
                    <asp:Label ID="UrlLabel" runat="server" Text='<%# Eval("Url") %>' />
                </td>
                <td>
                    <asp:Label ID="CreditLimitLabel" runat="server" 
                        Text='<%# Eval("CreditLimit") %>' />
                </td>
                <td>
                    <asp:Label ID="CreatedDateLabel" runat="server" 
                        Text='<%# Eval("CreatedDate") %>' />
                </td>
                <td>
                    <asp:Label ID="CreatedByLabel" runat="server" Text='<%# Eval("CreatedBy") %>' />
                </td>
                <td>
                    <asp:Label ID="ModifiedDateLabel" runat="server" 
                        Text='<%# Eval("ModifiedDate") %>' />
                </td>
                <td>
                    <asp:Label ID="ModifiedByLabel" runat="server" 
                        Text='<%# Eval("ModifiedBy") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="itemPlaceholderContainer" runat="server" border="0" style="">
                            <tr runat="server" style="">
                                <th runat="server">
                                    ID</th>
                                <th runat="server">
                                    FirstName</th>
                                <th runat="server">
                                    LastName</th>
                                <th runat="server">
                                    Address</th>
                                <th runat="server">
                                    Phone</th>
                                <th runat="server">
                                    ZipCode</th>
                                <th runat="server">
                                    City</th>
                                <th runat="server">
                                    State</th>
                                <th runat="server">
                                    CountryID</th>
                                <th runat="server">
                                    EmailAddress</th>
                                <th runat="server">
                                    Url</th>
                                <th runat="server">
                                    CreditLimit</th>
                                <th runat="server">
                                    CreatedDate</th>
                                <th runat="server">
                                    CreatedBy</th>
                                <th runat="server">
                                    ModifiedDate</th>
                                <th runat="server">
                                    ModifiedBy</th>
                            </tr>
                            <tr ID="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="">
                        <asp:DataPager ID="DataPager1" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                                    ShowLastPageButton="True" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="">
                <td>
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                </td>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                </td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                </td>
                <td>
                    <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                </td>
                <td>
                    <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
                </td>
                <td>
                    <asp:Label ID="ZipCodeLabel" runat="server" Text='<%# Eval("ZipCode") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="StateLabel" runat="server" Text='<%# Eval("State") %>' />
                </td>
                <td>
                    <asp:Label ID="CountryIDLabel" runat="server" Text='<%# Eval("CountryID") %>' />
                </td>
                <td>
                    <asp:Label ID="EmailAddressLabel" runat="server" 
                        Text='<%# Eval("EmailAddress") %>' />
                </td>
                <td>
                    <asp:Label ID="UrlLabel" runat="server" Text='<%# Eval("Url") %>' />
                </td>
                <td>
                    <asp:Label ID="CreditLimitLabel" runat="server" 
                        Text='<%# Eval("CreditLimit") %>' />
                </td>
                <td>
                    <asp:Label ID="CreatedDateLabel" runat="server" 
                        Text='<%# Eval("CreatedDate") %>' />
                </td>
                <td>
                    <asp:Label ID="CreatedByLabel" runat="server" Text='<%# Eval("CreatedBy") %>' />
                </td>
                <td>
                    <asp:Label ID="ModifiedDateLabel" runat="server" 
                        Text='<%# Eval("ModifiedDate") %>' />
                </td>
                <td>
                    <asp:Label ID="ModifiedByLabel" runat="server" 
                        Text='<%# Eval("ModifiedBy") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
</asp:Content>

