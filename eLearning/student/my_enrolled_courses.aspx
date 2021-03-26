<%@ Page Title="" Language="C#" MasterPageFile="~/student/student.Master" AutoEventWireup="true" CodeBehind="my_enrolled_courses.aspx.cs" Inherits="eLearning.student.my_enrolled_courses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

      <div class="breadcrumbs">
        <div class="col-sm-4">
            <div class="page-header float-left">
                <div class="page-title">
                    <h1>My Enrolled Cources.</h1>
                </div>
            </div>
        </div>

    </div>

    <div class="card-body table-responsive">
         <asp:DataList ID="d1" runat="server">
             <HeaderTemplate>
                 <table class="table table-hover">
                     <thead class="thead-dark" >
                
                </thead>
             </HeaderTemplate>
             <ItemTemplate>

             </ItemTemplate>
             <FooterTemplate>
                 </table>
             </FooterTemplate>
         </asp:DataList>
    </div>

</asp:Content>
