<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="display_all_courses.aspx.cs" Inherits="eLearning.admin.display_all_courses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

<script src="https://code.jquery.com/jquery-3.3.1.js"></script>

    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/dt-1.10.21/datatables.min.css"/>
 
<script type="text/javascript" src="https://cdn.datatables.net/v/dt/dt-1.10.21/datatables.min.js"></script>

    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Courses</strong>
                        </div>
                        <div class="card-body table-responsive">

                            <asp:Repeater ID="r1" runat="server">
                                <HeaderTemplate >
                                    <table id="example" class="table-sm table-hover" >
                              <thead class="thead-dark"  >
                                <tr >
                                    <th scope="col">Course image</th>
                                  <th scope="col">Course name</th>
                                  <th scope="col">Course lecturer</th>
                                  <th scope="col">Course Content</th>
                                   <th  scope="col">Course pdf</th>
                                    <th scope="col">Course ppt</th>
                                   <th scope="col">Course video</th>
                                    <th scope="col" > Edit books</th>
                                    <th scope="col" >Delete Course</th>
                                </tr>
                              </thead>
                              <tbody>
                                  </HeaderTemplate>
                                <ItemTemplate>
                                 <tr>
                                   <td><img src="<%#Eval("course_image") %>" alt="No image" height="60" width="60" /></td>
                                  <td><%#Eval("course_name") %></td>
                                  <td><%#Eval("course_lecturer") %></td>
                                  <td><%#Eval("course_content") %></td>
                                  <td><%#Eval("course_pdf") %><br /><%#checkpdf(Eval("course_pdf"),Eval("id")) %></td>
                                  <td><%#Eval("course_ppt") %><br /><%#checkppt(Eval("course_ppt"),Eval("id")) %></td>
                                  <td><%#Eval("course_videos") %><br /><%#checkvideo(Eval("course_videos"),Eval("id")) %></td>
                                     <td><a style="color:forestgreen" href="edit_course.aspx?id=<%#Eval("id") %>">Edit Course</a></td>
                                     <td><a style="color:red" href="delete_files.aspx?id3=<%#Eval("id") %>">Delete Course</a></td>
                                     </tr>
                                </ItemTemplate>
                                <FooterTemplate>
                                     </tbody>
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
