<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <p><b>EMAIL VALIDATION WEB PAGE</b></p>
    
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Height="35px" 
            ontextchanged="TextBox1_TextChanged" Width="276px" BorderColor="#0033CC" 
            CausesValidation="True" Font-Size="Medium"></asp:TextBox>
    
    <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Height="35px" Text="Validate" 
        Width="136px" BackColor="#3399FF" BorderColor="Blue" BorderStyle="Solid" 
            Font-Bold="True" ForeColor="White" onclick="Button1_Click" />
        </b>
    
        <br />
    
    </div>
    </form>
</body>
</html>
