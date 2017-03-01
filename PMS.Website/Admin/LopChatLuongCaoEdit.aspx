<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LopChatLuongCaoEdit.aspx.cs" Inherits="LopChatLuongCaoEdit" Title="LopChatLuongCao Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Lop Chat Luong Cao - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLop" runat="server" DataSourceID="LopChatLuongCaoDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopChatLuongCaoFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopChatLuongCaoFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LopChatLuongCao not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LopChatLuongCaoDataSource ID="LopChatLuongCaoDataSource" runat="server"
			SelectMethod="GetByMaLop"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLop" QueryStringField="MaLop" Type="String" />

			</Parameters>
		</data:LopChatLuongCaoDataSource>
		
		<br />

		

</asp:Content>

