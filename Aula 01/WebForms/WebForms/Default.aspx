<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>Oi, eu sou a página interna</h2>

    <table>
        <tr>
            <td>
                <asp:textbox id="TextBox1" runat="server"></asp:textbox>
            </td>
            <td>
                <asp:button id="Button1" runat="server" text="Button" OnClick="Button1_Click" style="height: 35px" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:label id="Label1" runat="server" text="Label"></asp:label>
            </td>
        </tr>
    </table>

</asp:Content>

