<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienCamKetKhongTruThueEdit.aspx.cs" Inherits="GiangVienCamKetKhongTruThueEdit" Title="GiangVienCamKetKhongTruThue Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Cam Ket Khong Tru Thue - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaGiangVien, NamHoc, HocKy" runat="server" DataSourceID="GiangVienCamKetKhongTruThueDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienCamKetKhongTruThueFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienCamKetKhongTruThueFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>GiangVienCamKetKhongTruThue not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:GiangVienCamKetKhongTruThueDataSource ID="GiangVienCamKetKhongTruThueDataSource" runat="server"
			SelectMethod="GetByMaGiangVienNamHocHocKy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaGiangVien" QueryStringField="MaGiangVien" Type="String" />
<asp:QueryStringParameter Name="NamHoc" QueryStringField="NamHoc" Type="String" />
<asp:QueryStringParameter Name="HocKy" QueryStringField="HocKy" Type="String" />

			</Parameters>
		</data:GiangVienCamKetKhongTruThueDataSource>
		
		<br />


</asp:Content>

