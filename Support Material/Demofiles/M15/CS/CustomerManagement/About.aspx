<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="AboutContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="Server">
    <asp:ScriptManagerProxy runat="server" ID="AboutScriptManagerProxy" />
    <asp:Panel ID="AboutPanel" runat="server" Style="display: none">
        <asp:UpdatePanel ID="AboutUpdatePanel" runat="server">
            <ContentTemplate>
                <asp:Panel runat="server" ID="AboutPopupPanel" CssClass="aboutPopupPanel">
                    <br />
                    &nbsp;<b>About Contoso Customer Management</b>&nbsp;<br />
                    <br />
                    &nbsp;Copyright © 2010 by Contoso&nbsp;<br />
                    <br />
                    <asp:Button ID="ShowModalButton" runat="server" CssClass="displayNone" />
                    <ajaxToolKit:ModalPopupExtender ID="AboutModalPopupExtender" runat="server" TargetControlID="ShowModalButton"
                        PopupControlID="AboutPanel" CancelControlID="CloseButton" BackgroundCssClass="modalPopup" />
                    <asp:Button ID="CloseButton" runat="server" CausesValidation="False" OnClick="CloseButton_Click"
                        Text="Close" />
                    <br />
                    <br />
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>
</asp:Content>
