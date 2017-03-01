<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoChucDanhChuyenMonEdit.aspx.cs" Inherits="HeSoChucDanhChuyenMonEdit" Title="HeSoChucDanhChuyenMon Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Chuc Danh Chuyen Mon - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHeSo" runat="server" DataSourceID="HeSoChucDanhChuyenMonDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoChucDanhChuyenMonFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HeSoChucDanhChuyenMonFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>HeSoChucDanhChuyenMon not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:HeSoChucDanhChuyenMonDataSource ID="HeSoChucDanhChuyenMonDataSource" runat="server"
			SelectMethod="GetByMaHeSo"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHeSo" QueryStringField="MaHeSo" Type="String" />

			</Parameters>
		</data:HeSoChucDanhChuyenMonDataSource>
		
		<br />

		

</asp:Content>

