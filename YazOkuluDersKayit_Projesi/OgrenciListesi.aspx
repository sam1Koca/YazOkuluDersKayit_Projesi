<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkuluDersKayit_Projesi.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci İD</th>

            <th>Öğrenci AD</th>

            <th>Öğrenci SOYAD</th>

            <th>Öğrenci NUMARA</th>

            <th>Öğrenci ŞİFRE</th>

            <th>Öğrenci FOTOĞRAF</th>

            <th>Öğrenci BAKİYE</th>

            <th>İşlemler</th>
        </tr>
        <tbody>
            <!--Repeater buradaki verileri Tekrarlayacak, bu işlem biz istediğimiz sürece olacak -->
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <!--Buradakileri Entity'deki ismi ne ise onu verdim, katmanlı mimari kullandığım için -->
                <td><%#Eval("İD")%></td>
                <td><%#Eval("AD")%></td>
                <td><%#Eval("SOYAD")%></td>
                <td><%#Eval("NUMARA")%></td>
                <td><%#Eval("FOTOGRAF")%></td>
                <td><%#Eval("SİFRE")%></td>
                <td><%#Eval("BAKİYE")%></td>
                <td>
                    <asp:HyperLink NavigateUrl= '<%# "~/OgrenciSil.aspx?OGRID=" + Eval("İD") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                    <asp:HyperLink NavigateUrl= '<%# "~/OgrenciGuncelle.aspx?OGRID=" + Eval("İD") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                </td>
                    

            </tr>
                    <!--Ögeleri'de Item Template tutacak, repeater'ın içinde.-->
                    </ItemTemplate> 
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
