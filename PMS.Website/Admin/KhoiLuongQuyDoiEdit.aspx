<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongQuyDoiEdit.aspx.cs" Inherits="KhoiLuongQuyDoiEdit" Title="KhoiLuongQuyDoi Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Quy Doi - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoiLuongQuyDoi" runat="server" DataSourceID="KhoiLuongQuyDoiDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongQuyDoiFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongQuyDoiFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KhoiLuongQuyDoi not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KhoiLuongQuyDoiDataSource ID="KhoiLuongQuyDoiDataSource" runat="server"
			SelectMethod="GetByMaKhoiLuongQuyDoi"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoiLuongQuyDoi" QueryStringField="MaKhoiLuongQuyDoi" Type="String" />

			</Parameters>
		</data:KhoiLuongQuyDoiDataSource>
		
		<br />

		

</asp:Content>

