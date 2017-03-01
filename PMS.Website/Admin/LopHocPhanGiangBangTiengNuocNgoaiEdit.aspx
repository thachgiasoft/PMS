<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LopHocPhanGiangBangTiengNuocNgoaiEdit.aspx.cs" Inherits="LopHocPhanGiangBangTiengNuocNgoaiEdit" Title="LopHocPhanGiangBangTiengNuocNgoai Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Lop Hoc Phan Giang Bang Tieng Nuoc Ngoai - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLopHocPhan" runat="server" DataSourceID="LopHocPhanGiangBangTiengNuocNgoaiDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopHocPhanGiangBangTiengNuocNgoaiFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopHocPhanGiangBangTiengNuocNgoaiFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LopHocPhanGiangBangTiengNuocNgoai not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LopHocPhanGiangBangTiengNuocNgoaiDataSource ID="LopHocPhanGiangBangTiengNuocNgoaiDataSource" runat="server"
			SelectMethod="GetByMaLopHocPhan"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLopHocPhan" QueryStringField="MaLopHocPhan" Type="String" />

			</Parameters>
		</data:LopHocPhanGiangBangTiengNuocNgoaiDataSource>
		
		<br />

		

</asp:Content>

