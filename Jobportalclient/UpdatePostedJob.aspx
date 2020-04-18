<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="UpdatePostedJob.aspx.cs" Inherits="Jobportalclient.UpdatePostedJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" CellPadding="3" GridLines="Horizontal" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
			 <asp:TemplateField>
               
                 <ItemTemplate>
                    <asp:Button class="btn btn-primary" ID  ="Apply" Text="Withdraw" runat="server" OnClick="LnKB_Click" />
                </ItemTemplate>
            </asp:TemplateField>

<asp:TemplateField><ItemTemplate>
                    <asp:Button class="btn btn-primary" ID  ="Update" Text="Update" runat="server" OnClick="updatedetails" />
                </ItemTemplate>
    </asp:TemplateField>                        
                
                                                                                                                           </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>


        </div>
    </form>
</body>
</html>
