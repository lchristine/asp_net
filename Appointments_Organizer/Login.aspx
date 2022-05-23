<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Appointments_Organizer.WebForm1" %>

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
    <title>Login</title>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body style="text-align:center;background-color:lightgrey">
    <form id="form1" runat="server">
        <br/><br /><br /><br />
    <div id="box">
    <div style="text-align:right;">
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Administration" />
        </div>
        <div>
            <h1 style="text-align:center">LOGIN/SIGN UP</h1>
        </div>
        <div >
        <table style="color:lightgrey; background-color:#72758c;border:1px solid black;margin-left:auto;margin-right:auto;">
        <tr>

            <td>AMKA:&nbsp&nbsp</td><td><asp:TextBox ID="TextBox1" runat="server" Width="206px"></asp:TextBox><br /><br /></td>

        </tr>
        <tr>

           <td>Password:&nbsp&nbsp</td><td><asp:TextBox type="password" ID="TextBox2" runat="server" Width="208px"></asp:TextBox><br /><br /></td>
        </tr>
        
            <tr><td>&nbsp</td></td><td><asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></td></tr>

            </table>
            </div>
        <div>
            <br /><br /><br /><br />
            <p><a style="color:lightgrey" href="Register.aspx">If you have no active account,click here to register</a></p>
            <br /><br />
        </div>
        </div>
    </form>
</body>
</html>
