<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BESTTeplate.aspx.cs" Inherits="TryCookie.BESTTeplate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Try BootStrap</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <script src="js/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-4 col-sm-6">

                    <!-- Button trigger modal -->
                    <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
                        Launch demo modal
                    </button>

                    <!-- Modal -->
                    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel">87</h5>
                                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                </div>
                                <div class="modal-body">
                                    會想要第一批打高端的腦袋都裝什麼啊
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="btn1" runat="server" Text="Close" CssClass="btn btn-secondary" />
                                    <asp:Button ID="btn2" runat="server" Text="Save changes" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>

                </div>

                <div class="col-md-4 col-sm-6">

                    <div class="mb-3">
                        <label for="exampleFormControlInput1" class="form-label">Email address</label>
                        <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com">
                    </div>
                    <div class="mb-3">
                        <label for="exampleFormControlTextarea1" class="form-label">Example textarea</label>
                        <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
                    </div>

                </div>

                <div class="col-md-4 col-sm-6">
                    <div class="mb-3">
                        <label for="<%= this.txtEmail.ClientID %>" class="form-label">Email Address</label>
                        <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" CssClass="form-control" placeholder="aaa@ubay.tw"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="<%= this.txtdesc.ClientID %>" class="form-label">Desc</label>
                        <asp:TextBox runat="server" ID="txtdesc" CssClass="form-control" Rows="3"></asp:TextBox>
                        
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
