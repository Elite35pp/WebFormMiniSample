<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.Login" %>

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

        .email,
        .password {
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
    </style>
    <div class="container  py-5">
        <div class="d-flex justify-content-center align-items-center w-100">
            <div class="text-center  w-50">
                <div>
                    <h2>請選擇註冊或是登入</h2>
                    <label for="email">信箱　</label>
                    <input type="email" name="email" class="email" placeholder="請輸入信箱"><br>
                    <label for="password">密碼　</label>
                    <input type="password" name="password" class="password" placeholder="請輸入密碼">
                </div>
                <br />
                <div id="btn">
                    <input type="button" value="註冊" class="signUp">
                    <input type="button" value="登入" class="logIn">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
