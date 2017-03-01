<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DinhMucGioChuanEdit.aspx.cs" Inherits="DinhMucGioChuanEdit" Title="DinhMucGioChuan Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Dinh Muc Gio Chuan - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaDinhMuc" runat="server" DataSourceID="DinhMucGioChuanDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DinhMucGioChuanFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DinhMucGioChuanFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>DinhMucGioChuan not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:DinhMucGioChuanDataSource ID="DinhMucGioChuanDataSource" runat="server"
			SelectMethod="GetByMaDinhMuc"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaDinhMuc" QueryStringField="MaDinhMuc" Type="String" />

			</Parameters>
		</data:DinhMucGioChuanDataSource>
		
		<br />

		

</asp:Content>

