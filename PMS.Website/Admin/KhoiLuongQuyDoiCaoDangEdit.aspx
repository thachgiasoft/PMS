<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongQuyDoiCaoDangEdit.aspx.cs" Inherits="KhoiLuongQuyDoiCaoDangEdit" Title="KhoiLuongQuyDoiCaoDang Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Quy Doi Cao Dang - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoiLuongQuyDoiCaoDang" runat="server" DataSourceID="KhoiLuongQuyDoiCaoDangDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongQuyDoiCaoDangFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongQuyDoiCaoDangFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KhoiLuongQuyDoiCaoDang not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KhoiLuongQuyDoiCaoDangDataSource ID="KhoiLuongQuyDoiCaoDangDataSource" runat="server"
			SelectMethod="GetByMaKhoiLuongQuyDoiCaoDang"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoiLuongQuyDoiCaoDang" QueryStringField="MaKhoiLuongQuyDoiCaoDang" Type="String" />

			</Parameters>
		</data:KhoiLuongQuyDoiCaoDangDataSource>
		
		<br />

		

</asp:Content>

