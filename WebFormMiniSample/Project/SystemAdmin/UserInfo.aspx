<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="Project.SystemAdmin.UserInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table>
            <tr>
                <td colspan="2">
                    <h1>服飾訂購系統後台</h1>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="UserInfo.aspx">使用者資訊</a><br />
                    <a href="ProductList.aspx">庫存管理</a>
                </td>
                <td>
                    <table>
                        <tr>
                            <th>帳號:　</th>
                            <td>
                                <asp:Literal ID="ltlAccount" runat="server"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="Button1" runat="server" Text="登出" OnClick="btnLogout_Click" CssClass="btn btn-link" />
                </td>
            </tr>
        </table>
</asp:Content>
