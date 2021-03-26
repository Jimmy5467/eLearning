<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="add_course.aspx.cs" Inherits="eLearning.admin.add_course" %>
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
                                          <label for="" class="control-label mb-1">Course Title</label>
                                          <asp:TextBox id="coursetitle" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Course Lecturer</label>
                                          <asp:TextBox id="lect" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Course content</label>
                                          <asp:TextBox id="content" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Course Image</label><br>
                                          <asp:FileUpload id="img" runat="server" class="form"></asp:FileUpload>
                                      </div>
                                      
                                      <div class="form-group ">
                                          <label for="" class="control-label mb-1">Course pdf</label><br>
                                          <asp:FileUpload id="pdf" runat="server" class="form"></asp:FileUpload>
                                      </div>
                                      
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Course ppt</label><br>
                                          <asp:FileUpload id="ppt" runat="server" class="form"></asp:FileUpload>
                                      </div>
                                      <div class="form-group">
                                          <label for=""  class="control-label mb-1">Course video</label> <br>
                                          <asp:FileUpload id="video" runat="server" class="form"  ></asp:FileUpload>
                                      </div>

                                      <div>
                                          <asp:Button ID="b1" OnClick="b1_Click" runat="server" class="btn btn-lg btn-info btn-block" Text="Add New Course" />
                                      </div>
                                      <div class="alert alert-success" id="msg" runat="server" style="margin-top:15px; display:none">
                                            <strong>Your course added Successfully!</strong> 
                                      </div>
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->
</asp:Content>
