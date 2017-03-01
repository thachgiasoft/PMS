<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienTinhLuongThinhGiangEdit.aspx.cs" Inherits="GiangVienTinhLuongThinhGiangEdit" Title="GiangVienTinhLuongThinhGiang Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Tinh Luong Thinh Giang - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaGiangVien, NamHoc, HocKy, MaCauHinhChotGio, MaMonHoc, MaLopSinhVien" runat="server" DataSourceID="GiangVienTinhLuongThinhGiangDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienTinhLuongThinhGiangFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienTinhLuongThinhGiangFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>GiangVienTinhLuongThinhGiang not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:GiangVienTinhLuongThinhGiangDataSource ID="GiangVienTinhLuongThinhGiangDataSource" runat="server"
			SelectMethod="GetByMaGiangVienNamHocHocKyMaCauHinhChotGioMaMonHocMaLopSinhVien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaGiangVien" QueryStringField="MaGiangVien" Type="String" />
<asp:QueryStringParameter Name="NamHoc" QueryStringField="NamHoc" Type="String" />
<asp:QueryStringParameter Name="HocKy" QueryStringField="HocKy" Type="String" />
<asp:QueryStringParameter Name="MaCauHinhChotGio" QueryStringField="MaCauHinhChotGio" Type="String" />
<asp:QueryStringParameter Name="MaMonHoc" QueryStringField="MaMonHoc" Type="String" />
<asp:QueryStringParameter Name="MaLopSinhVien" QueryStringField="MaLopSinhVien" Type="String" />

			</Parameters>
		</data:GiangVienTinhLuongThinhGiangDataSource>
		
		<br />


</asp:Content>

