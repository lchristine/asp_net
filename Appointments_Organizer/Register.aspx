<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Appointments_Organizer.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
         #box {
            border: 2px solid black;
            padding: 10px;
            margin: 50px;
            background-color:#424454;
        }
        body {
            background-image: url('kk.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
            }
    </style>
    <title>Register</title>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body style="text-align:center;background-color:cornflowerblue;">
    <form id="form1" runat="server">
        <div id="box">
        <div style="text-align:right;">

            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" />

        </div>

        <div>
            <h1>REGISTER</h1>
        </div>
         <div >
          <table style="color:lightgrey; background-color:#72758c;border:1px solid black;margin-left:auto;margin-right:auto;">
              <tr><td> AMKA:&nbsp&nbsp</td><td> <asp:TextBox ID="TextBox1" runat="server" Width="206px"></asp:TextBox><br /><br /></td></tr>
              <tr><td>Password:&nbsp&nbsp</td><td><asp:TextBox type="password" ID="TextBox2" runat="server" Width="208px"></asp:TextBox><br /><br /></td></tr>
              <tr><td>Confirm password:&nbsp&nbsp</td><td><asp:TextBox type="password" ID="TextBox3" runat="server" Width="208px"></asp:TextBox><br /><br /></td></tr>
              <tr><td></td><td><asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /></td></tr>
          </table>
             <br /> <br /> 
          </div>
        </div>
    </form>
</body>
</html>
