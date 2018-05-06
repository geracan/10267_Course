<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Customer.ascx.cs" Inherits="Customer"
    ClassName="Customer" %>
<div class="customerTable">
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerFirstNameLabel" runat="server" Text="First Name:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerFirstNameTextBox" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CustomerFirstNameRequiredFieldValidator" ControlToValidate="CustomerFirstNameTextBox"
                runat="server" ErrorMessage="The Customer First Name must be filled in." Text="*"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerLastNameLabel" runat="server" Text="Last Name:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerLastNameTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CustomerLastNameRequiredFieldValidator" ControlToValidate="CustomerLastNameTextBox"
                runat="server" ErrorMessage="The Customer Last Name must be filled in." Text="*"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerAddressLabel" runat="server" Text="Address:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerAddressTextBox" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CustomerAddressRequiredFieldValidator" ControlToValidate="CustomerAddressTextBox"
                runat="server" ErrorMessage="The Address must be filled in." Text="*"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerZipCodeLabel" runat="server" Text="Zip Code:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerZipCodeTextBox" runat="server" MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CustomerZipCodeRequiredFieldValidator" ControlToValidate="CustomerZipCodeTextBox"
                runat="server" ErrorMessage="The Zip Code must be filled in." Text="*"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerCityLabel" runat="server" Text="City:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerCityTextBox" runat="server" MaxLength="30"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CustomerCityRequiredFieldValidator" ControlToValidate="CustomerCityTextBox"
                runat="server" ErrorMessage="The City must be filled in." Text="*"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerStateLabel" runat="server" Text="State:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerStateTextBox" runat="server" MaxLength="30"></asp:TextBox>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerCountryLabel" runat="server" Text="Country:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:DropDownList ID="CustomerCountryDropDownList" runat="server">
                <asp:ListItem>USA</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="CustomerCountryRequiredFieldValidator" ControlToValidate="CustomerCountryDropDownList"
                runat="server" ErrorMessage="A country must be selected." Text="*"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerPhoneLabel" runat="server" Text="Phone:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerPhoneTextBox" runat="server" MaxLength="30"></asp:TextBox>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerEmailAddressLabel" runat="server" Text="Email Address:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerEmailAddressTextBox" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RegularExpressionValidator ID="CustomerEmailAddressRegularExpressionValidator"
                ControlToValidate="CustomerEmailAddressTextBox" runat="server" ErrorMessage="The Email Address must be valid."
                Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerWebAddressLabel" runat="server" Text="Web Address:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerWebAddressTextBox" runat="server" MaxLength="80"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CustomerWebAddressRequiredFieldValidator" ControlToValidate="CustomerWebAddressTextBox"
                runat="server" ErrorMessage="The Web Address must be filled in." Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="CustomerWebAddressRegularExpressionValidator"
                ControlToValidate="CustomerWebAddressTextBox" runat="server" ErrorMessage="The Web Address must be valid."
                Text="*" ValidationExpression="^http(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerCreditLimitLabel" runat="server" Text="Credit Limit:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:TextBox ID="CustomerCreditLimitTextBox" runat="server" MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CustomerCreditLimitRequiredFieldValidator" ControlToValidate="CustomerCreditLimitTextBox"
                runat="server" ErrorMessage="The Credit Limit must be filled in." Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="CustomerCreditLimitRangeValidator" ControlToValidate="CustomerCreditLimitTextBox"
                runat="server" MinimumValue="0" MaximumValue="50000" ErrorMessage="The Credit Limit must be within the valid range."
                Text="*" Type="Integer"></asp:RangeValidator>
        </div>
    </div>
    <div class="customerTableRow">
        <div class="customerTableLeftCol">
            <asp:Label ID="CustomerNewsSubscriberLabel" runat="server" Text="News Subscriber:"></asp:Label>
        </div>
        <div class="customerTableRightCol">
            <asp:CheckBox ID="CustomerNewsSubscriberCheckBox" runat="server" />
        </div>
    </div>
    <div class="customerTableFooter">
        <asp:ValidationSummary ID="CustomerValidationSummary" runat="server"></asp:ValidationSummary>
        <asp:Button ID="CustomerInsertButton" runat="server" Text="Insert" OnClick="CustomerInsertButton_Click" />
        &nbsp;<asp:Button ID="CustomerCancelButton" runat="server" Text="Cancel" OnClick="CustomerCancelButton_Click"
            CausesValidation="false" />
    </div>
</div>
