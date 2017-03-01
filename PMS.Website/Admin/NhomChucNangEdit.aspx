<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomChucNangEdit.aspx.cs" Inherits="NhomChucNangEdit" Title="NhomChucNang Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Chuc Nang - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaChucNang, MaNhomQuyen" runat="server" DataSourceID="NhomChucNangDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomChucNangFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomChucNangFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NhomChucNang not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NhomChucNangDataSource ID="NhomChucNangDataSource" runat="server"
			SelectMethod="GetByMaChucNangMaNhomQuyen"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaChucNang" QueryStringField="MaChucNang" Type="String" />
<asp:QueryStringParameter Name="MaNhomQuyen" QueryStringField="MaNhomQuyen" Type="String" />

			</Parameters>
		</data:NhomChucNangDataSource>
		
		<br />


</asp:Content>

