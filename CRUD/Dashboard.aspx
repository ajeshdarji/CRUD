<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="CRUD.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px" OnMenuItemClick="Menu1_MenuItemClick">
                            <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                            <DynamicMenuStyle BackColor="#FFFBD6" />
                            <DynamicSelectedStyle BackColor="#FFCC66" />
                            <DynamicItemTemplate>
                                <%# Eval("Text") %>
                            </DynamicItemTemplate>
                            <Items>
                                <asp:MenuItem NavigateUrl="~/Dashboard.aspx" Text="Dash Board" Value="Dash Board"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="~/Register.aspx" Text="Craete New" Value="Craete New"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="~/Login.aspx" Text="Logout" Value="Logout"></asp:MenuItem>
                            </Items>
                            <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                            <StaticSelectedStyle BackColor="#FFCC66" />
                            <StaticItemTemplate>
                                <%# Eval("Text") %>
                            </StaticItemTemplate>
                        </asp:Menu>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="Username" HeaderText="Username" />
                                <asp:BoundField DataField="email" HeaderText="email" />
                                <asp:BoundField DataField="phone no" HeaderText="phone no" />
                                <asp:BoundField DataField="Country" HeaderText="Country" />
                                <asp:ImageField DataImageUrlField="image" HeaderText="image">
                                    <ControlStyle Height="50px" Width="50px" />
                                </asp:ImageField>
                                <asp:BoundField DataField="password" HeaderText="password" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
