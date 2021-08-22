<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
      body{
        background-color: beige;
      }
    </style>
<body>
    <div id="carouselExampleFade" class="carousel slide carousel-fade" data-bs-ride="carousel">
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img src="001.jpg" class="d-block w-100" alt="..." width="50%" height="700">
        </div>
        <div class="carousel-item">
          <img src="002.jpg" class="d-block w-100" alt="..." width="50%" height="700">
        </div>
        <div class="carousel-item">
          <img src="003.jpg" class="d-block w-100" alt="..." width="50%" height="700">
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
      <br><br><br>
      <div class="container  py-5 ">
        <div class="d-flex justify-content-center align-items-center w-100">
        <div class="card" style="width: 18rem;">
          <img src="001.jpg" class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">浪漫衣</h5>
            <p class="card-text">NT$8,700</p>
            <a href="#" class="btn btn-primary">加入購物車</a>
          </div>
        </div>
        <div class="card" style="width: 18rem;">
          <img src="001.jpg" class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">浪漫衣</h5>
            <p class="card-text">NT$8,700</p>
            <a href="#" class="btn btn-primary">加入購物車</a>
          </div>
        </div>
        <div class="card" style="width: 18rem;">
          <img src="001.jpg" class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">浪漫衣</h5>
            <p class="card-text">NT$8,700</p>
            <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
              加入購物車
            </button>
            <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
              <div class="modal-dialog">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">
                      <img src="003.jpg" class="img-fluid" alt="Responsive image">
                    </h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                  </div>
                  <div class="modal-body">
                    <a>Toi e moi -晉瑞浪漫衣(男)<br>
                      NT$8,700
                    </a>
                    <select class="form-select form-select-sm" aria-label=".form-select-sm example" style="width:auto;">                   
                      <option selecte>S</option>
                      <option value="1">M</option>
                      <option value="2">L</option>
                    </select>
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-primary" >加入購物車</button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
        </div>
</body>
</asp:Content>

