<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        
    </style>
    <div id="carouselExampleFade" class="carousel slide carousel-fade" data-bs-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="Test01.jpg" class="d-block w-100" alt="..."  height="500">
            </div>
            <div class="carousel-item">
                <img src="Test02.jpg" class="d-block w-100" alt="..."  height="500">
            </div>
            <div class="carousel-item">
                <img src="Test03.jpg" class="d-block w-100" alt="..."  height="500">
            </div>
            <div class="carousel-item">
                <img src="Test04.jpg" class="d-block w-100" alt="..."  height="500">
            </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>
    <br>
    <br>
    <br>
    <div class="container  py-5 ">
        <div class="d-flex justify-content-center align-items-center w-100">
            <div class="card" style="width: 18rem;">
                <img src="01.jpg" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">男裝 圓領T恤 (短袖)</h5>
                    <p class="card-text">NT$8,700</p>
                    <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
                        加入購物車
                    </button>
                    <div class="modal fade" id="exampleModal2" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel2">
                                        <a>請選擇規格</a>
                                    </h5>
                                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                </div>
                                <div class="modal-body">
                                    <img src="01.jpg" class=" figure-img img-fluid rounded " alt="Responsive image"><br />
                                    <a>男裝 圓領T恤 (短袖)</a><br />
                                    <a>NT$8,700</a><br />
                                    <select class="form-select form-select-sm" aria-label=".form-select-sm example" style="width: auto;">
                                        <option selecte="0">S</option>
                                        <option value="1">M</option>
                                        <option value="2">L</option>
                                    </select>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="Button3" runat="server" Text="加入購物車" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />
            <div class="card  " style="width: 18rem;">
                <img src="02.jpg" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">男裝 寬版圓領T恤 (短袖)</h5>
                    <p class="card-text">NT$8,700</p>
                    <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
                        加入購物車
                    </button>
                    <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel1">
                                        <a>請選擇規格</a>
                                    </h5>
                                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                </div>
                                <div class="modal-body">
                                    <img src="02.jpg" class=" figure-img img-fluid rounded " alt="Responsive image"><br />
                                    <a>男裝 寬版圓領T恤 (短袖)</a><br />
                                    <a>NT$8,700</a><br />
                                    <select class="form-select form-select-sm" aria-label=".form-select-sm example" style="width: auto;">
                                        <option selecte="0">S</option>
                                        <option value="1">M</option>
                                        <option value="2">L</option>
                                    </select>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="Button2" runat="server" Text="加入購物車" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />
            <div class="card" style="width: 18rem;">
                <img src="03.jpg" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">男裝 圓領T恤 (短袖)</h5>
                    <p class="card-text">NT$8,700</p>
                    <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
                        加入購物車
                    </button>
                    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel">
                                        <a>請選擇規格</a>
                                    </h5>
                                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                </div>
                                <div class="modal-body">
                                    <img src="03.jpg" class=" figure-img img-fluid rounded " alt="Responsive image"><br />
                                    <a>男裝 圓領T恤 (短袖)</a><br />
                                    <a>NT$8,700</a><br />
                                    <select class="form-select form-select-sm" aria-label=".form-select-sm example" style="width: auto;">
                                        <option selecte="0">S</option>
                                        <option value="1">M</option>
                                        <option value="2">L</option>
                                    </select>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="Button1" runat="server" Text="加入購物車" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        document.getElementById('kain').innerHTML = '<%=name %>'
    </script>
</asp:Content>

