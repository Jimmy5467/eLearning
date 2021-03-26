<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="display_student_info.aspx.cs" Inherits="eLearning.admin.display_student_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    
<script src="https://code.jquery.com/jquery-3.3.1.js"></script>

    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/dt-1.10.21/datatables.min.css"/>
 
<script type="text/javascript" src="https://cdn.datatables.net/v/dt/dt-1.10.21/datatables.min.js"></script>

     <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Student info</strong>
                               </div>
                        <div class="card-body table-responsive">

    <asp:Repeater ID="r1" runat="server">
        <HeaderTemplate>
            <table id="example" class="table table-hover">
                <thead class="thead-dark" >
                <tr>
                     <th scope="col">Images</th>
                    <th scope="col">firstname</th>
                    <th scope="col">lastname</th>
                    <th scope="col">username</th>
                    <th scope="col">email</th>
                    <th scope="col">contect</th>
                    <th scope="col">Status</th>
                    <th scope="col">Active</th>
                    <th scope="col">Deactive</th>

                </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>

            <tr>
                <td><img src="../<%#Eval("student_img") %>" height="60" width="60" /></td>
                <td><%#Eval("firstname") %></td>
                <td><%#Eval("lastname") %></td>
                <td><%#Eval("username") %></td>
                <td><%#Eval("email") %></td>
                <td><%#Eval("contect") %></td>
                <td><%#Eval("approved") %></td>
                <td><a href="student_active.aspx?id=<%#Eval("id") %>">Active</a></td>
                <td><a href="student_deactive.aspx?id=<%#Eval("id") %>">Deactive</a></td>
            </tr>


        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    
    </asp:Repeater>
                            
                        </div>
                    </div>
                </div>

     <script type="text/javascript">
      $(document).ready(function () {
          $('#example').DataTable({
              "pagingType":"full_numbers"
          })
      })
  </script>

</asp:Content>
