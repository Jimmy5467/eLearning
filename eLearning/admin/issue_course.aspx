<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="issue_course.aspx.cs" Inherits="eLearning.admin.issue_course" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

     
     <div class="col-lg-12">

                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Add new course</strong>
                        </div>
                        <div class="card-body">
                          
                          <div id="pay-invoice">
                              <div class="card-body">
                                  
                                 
                                  <form  id="fo1" runat="server" method="post" novalidate="novalidate">
                                      
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Username of Student</label>
                                           <asp:DropDownList id="username" runat="server" Class="form-control"></asp:DropDownList>     
                                          </div>
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Course Title</label>
                                            <asp:DropDownList ID="title" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="title_SelectedIndexChanged"></asp:DropDownList>
                          
                                          </div> 
                                      <div class="form-group">
                                      <asp:Image ID="i1" runat="server" Height="150" Width="150" /><br />
                                 <asp:Label ID="un" runat="server"></asp:Label><br />
                                       </div>
                                     

                                      <div>
                                          <asp:Button ID="b1" OnClick="b1_Click" runat="server" class="btn btn-lg btn-info btn-block" Text="Issue Course" />
                                      </div>
                                      
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->

</asp:Content>
