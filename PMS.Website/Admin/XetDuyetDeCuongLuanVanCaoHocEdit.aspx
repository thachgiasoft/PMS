<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="XetDuyetDeCuongLuanVanCaoHocEdit.aspx.cs" Inherits="XetDuyetDeCuongLuanVanCaoHocEdit" Title="XetDuyetDeCuongLuanVanCaoHoc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Xet Duyet De Cuong Luan Van Cao Hoc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="XetDuyetDeCuongLuanVanCaoHocDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/XetDuyetDeCuongLuanVanCaoHocFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/XetDuyetDeCuongLuanVanCaoHocFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>XetDuyetDeCuongLuanVanCaoHoc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:XetDuyetDeCuongLuanVanCaoHocDataSource ID="XetDuyetDeCuongLuanVanCaoHocDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:XetDuyetDeCuongLuanVanCaoHocDataSource>
		
		<br />

		

</asp:Content>

