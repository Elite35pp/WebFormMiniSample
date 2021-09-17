<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ManagerLogin.aspx.cs" Inherits="Project.ManagerLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        * {
            box-sizing: border-box;
        }

        .wrap {
            margin: 0 auto;
            width: 500px;
        }

        h2 {
            text-align: center;
            color: #25a6af;
        }

        .account,
        .password,
        .email {
            width: 500px;
            height: 40px;
            padding: 10px;
            border-radius: 10px;
            border: 1px solid #333;
        }

        label {
            padding-right: 10px;
        }

        input {
            margin-top: 10px;
        }

            input:focus {
                outline: none;
                /* 取消focus效果 */
            }

        #btn {
            text-align: center;
        }

            #btn input {
                width: 45%;
                margin: 2%;
                margin-top: 10px;
                border: none;
                height: auto;
                padding: 5px;
                font-size: 16px;
                border-radius: 100px;
            }

        .signUp,
        .logIn {
            cursor: pointer;
        }

        .signUp {
            background-color: #06a81c;
            color: #fff;
        }

            .signUp:hover {
                background-color: #047714;
                color: #fff;
            }

        .logIn {
            background-color: #ffce49;
            color: #816516;
        }

            .logIn:hover {
                background-color: #ffc31f;
                color: #816516;
            }

        body {
            background-color: beige;
        }
    </style>
    <div class="container  py-5">
        <div class="d-flex justify-content-center align-items-center w-100">
            <div class="text-center  w-50">
                <asp:PlaceHolder runat="server" ID="plcLogin" Visible="false">
                    <div>
                        <h2>後臺登入</h2>
                        <label for="account"></label>
                        <asp:TextBox ID="txtAccount" runat="server" placeholder="請輸入帳號" CssClass="account"></asp:TextBox><br />
                        <label for="password"></label>
                        <asp:TextBox ID="txtPWD" runat="server" TextMode="Password" placeholder="請輸入密碼" CssClass="password"></asp:TextBox><br />
                    </div>
                    <br />
                    <div id="btn">
                        <asp:Literal ID="ltlMsg" runat="server"></asp:Literal><br />
                        <asp:Button ID="btnLogin" runat="server" Text="登入" CssClass="signUp" OnClick="btnLogin_Click" />
                    </div>
                </asp:PlaceHolder>
            </div>
        </div>
    </div>
</asp:Content>
