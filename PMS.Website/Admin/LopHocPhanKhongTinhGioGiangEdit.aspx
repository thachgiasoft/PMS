<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LopHocPhanKhongTinhGioGiangEdit.aspx.cs" Inherits="LopHocPhanKhongTinhGioGiangEdit" Title="LopHocPhanKhongTinhGioGiang Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Lop Hoc Phan Khong Tinh Gio Giang - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLopHocPhan" runat="server" DataSourceID="LopHocPhanKhongTinhGioGiangDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopHocPhanKhongTinhGioGiangFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopHocPhanKhongTinhGioGiangFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LopHocPhanKhongTinhGioGiang not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LopHocPhanKhongTinhGioGiangDataSource ID="LopHocPhanKhongTinhGioGiangDataSource" runat="server"
			SelectMethod="GetByMaLopHocPhan"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLopHocPhan" QueryStringField="MaLopHocPhan" Type="String" />

			</Parameters>
		</data:LopHocPhanKhongTinhGioGiangDataSource>
		
		<br />

		

</asp:Content>

