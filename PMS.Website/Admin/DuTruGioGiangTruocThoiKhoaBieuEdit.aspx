<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DuTruGioGiangTruocThoiKhoaBieuEdit.aspx.cs" Inherits="DuTruGioGiangTruocThoiKhoaBieuEdit" Title="DuTruGioGiangTruocThoiKhoaBieu Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Du Tru Gio Giang Truoc Thoi Khoa Bieu - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="DuTruGioGiangTruocThoiKhoaBieuDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DuTruGioGiangTruocThoiKhoaBieuFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DuTruGioGiangTruocThoiKhoaBieuFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>DuTruGioGiangTruocThoiKhoaBieu not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:DuTruGioGiangTruocThoiKhoaBieuDataSource ID="DuTruGioGiangTruocThoiKhoaBieuDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:DuTruGioGiangTruocThoiKhoaBieuDataSource>
		
		<br />

		

</asp:Content>

