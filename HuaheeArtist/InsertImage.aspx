<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertImage.aspx.cs" Inherits="HuaheeArtist.InsertImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert the image to database</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">  
            <tr>  
                <td class="style1">  
                    Image Name:</td>  
                <td class="style2">  
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>  
                </td>  
                <td>  
                     </td>  
            </tr>  
            <tr>  
                <td class="style1">  
                    Upload Your Image:</td>  
                <td class="style2">  
                    <asp:FileUpload ID="FileUpload1" runat="server" />  
                </td>  
                <td>  
                    <asp:Label ID="Label1" runat="server"></asp:Label>  
                </td>  
            </tr>  
            <tr>  
                <td class="style1">  
                     </td>  
                <td class="style2">  
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Upload" />  
                </td>  
            </tr>  
        </table>  
        </div>
    </form>
</body>
</html>
