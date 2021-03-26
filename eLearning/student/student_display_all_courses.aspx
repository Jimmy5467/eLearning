<%@ Page Title="" Language="C#" MasterPageFile="~/student/student.Master" AutoEventWireup="true" CodeBehind="student_display_all_courses.aspx.cs" Inherits="eLearning.student.student_display_all_books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    
    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Courses</strong>
                            <input style="float:right;" id="myInput" type="text" placeholder="Search..">
                        </div>
                        <div class="card-body table-responsive">

                            <asp:Repeater ID="r1" runat="server">
                                <HeaderTemplate >
                                    <table class="table table-sm table-hover" >
                              <thead class="thead-dark" >
                                <tr >
                                    <th scope="col">Course image</th>
                                  <th scope="col">Course name</th>
                                  <th scope="col">Course lecturer</th>
                                  <th scope="col">Course Content</th>
                                   <th  scope="col">Course pdf</th>
                                    <th scope="col">Course ppt</th>
                                   <th scope="col">Course video</th>
                                   </tr>
                              </thead>
                              <tbody>
                                  </HeaderTemplate>
                                <ItemTemplate>
                                 <tr>
                                   <td><img src="../admin/<%#Eval("course_image") %>" alt="No image" height="60" width="60" /></td>
                                  <td><%#Eval("course_name") %></td>
                                  <td><%#Eval("course_lecturer") %></td>
                                  <td><%#Eval("course_content") %></td>
                                  <td><%#Eval("course_pdf") %><br /><%#checkpdf(Eval("course_pdf"),Eval("id")) %></td>
                                  <td><%#Eval("course_ppt") %><br /><%#checkppt(Eval("course_ppt"),Eval("id")) %></td>
                                  <td><%#Eval("course_videos") %><br /><%#checkvideo(Eval("course_videos"),Eval("id")) %></td>
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

  

</asp:Content>
