<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="edit_course.aspx.cs" Inherits="eLearning.admin.edit_course" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    
     <div class="col-lg-12">

                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Update course</strong>
                             <input style="float:right;" id="myInput" type="text" placeholder="Search..">
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
                                          <asp:FileUpload id="img" runat="server" class="form"></asp:FileUpload><br />
                                           <asp:Label Id="courseimage" runat="server" Text=""></asp:Label>
                                      </div>
                                      
                                      <div class="form-group ">
                                          <label for="" class="control-label mb-1">Course pdf</label><br>
                                          
                                          <asp:FileUpload id="pdf" runat="server" class="form"></asp:FileUpload><br />
                                          <asp:Label Id="coursepdf" runat="server" Text=""></asp:Label>
                                      </div>
                                      
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Course ppt</label><br>
                                          <asp:FileUpload id="ppt" runat="server" class="form"></asp:FileUpload><br />
                                            <asp:Label Id="courseppt" runat="server" Text=""></asp:Label>
                                      </div>
                                      <div class="form-group">
                                          <label for=""  class="control-label mb-1">Course video</label> <br>
                                                 <asp:FileUpload id="video" runat="server" class="form"  ></asp:FileUpload><br />
                                          <asp:Label Id="coursevideo" runat="server" Text=""></asp:Label>
                                   
                                      </div>

                                      <div>
                                          <asp:Button ID="b1" OnClick="b1_Click" runat="server" class="btn btn-lg btn-info btn-block" Text="Update Course" />
                                      </div>
                                      
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->

</asp:Content>
