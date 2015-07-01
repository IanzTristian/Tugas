<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HalamanKategori.aspx.cs" Inherits="AplikasiBarang.WebApp.HalamanKategori" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnCariById" runat="server" OnClick="btnCariById_Click" Text="Cari" />
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Kategori ID      "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtKategoriID" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Nama Kategori"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNamaKategori" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:DropDownList ID="dropKategori" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:Label ID="lblKeterangan" runat="server" Text="Keterangan :"></asp:Label>
        <br />
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    
        <br />
        <br />
        <asp:Button ID="btnTampilkanData" runat="server" OnClick="btnTampilkanData_Click" Text="Tampilkan Data" />
        <br />
        <asp:TextBox ID="txtCari" runat="server"></asp:TextBox>
        &nbsp;
        <asp:Button ID="btnCari" runat="server" OnClick="btnCari_Click" Text="Cari" />
        <asp:GridView ID="gvKategoriBarang" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
