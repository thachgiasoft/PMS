<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChiTietKhoiLuongEdit.aspx.cs" Inherits="ChiTietKhoiLuongEdit" Title="ChiTietKhoiLuong Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chi Tiet Khoi Luong - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaChiTiet" runat="server" DataSourceID="ChiTietKhoiLuongDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ChiTietKhoiLuongFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ChiTietKhoiLuongFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>ChiTietKhoiLuong not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:ChiTietKhoiLuongDataSource ID="ChiTietKhoiLuongDataSource" runat="server"
			SelectMethod="GetByMaChiTiet"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaChiTiet" QueryStringField="MaChiTiet" Type="String" />

			</Parameters>
		</data:ChiTietKhoiLuongDataSource>
		
		<br />

		

</asp:Content>

