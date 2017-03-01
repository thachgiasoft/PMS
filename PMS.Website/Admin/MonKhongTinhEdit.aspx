<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="MonKhongTinhEdit.aspx.cs" Inherits="MonKhongTinhEdit" Title="MonKhongTinh Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Mon Khong Tinh - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaMonHoc" runat="server" DataSourceID="MonKhongTinhDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/MonKhongTinhFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/MonKhongTinhFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>MonKhongTinh not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:MonKhongTinhDataSource ID="MonKhongTinhDataSource" runat="server"
			SelectMethod="GetByMaMonHoc"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaMonHoc" QueryStringField="MaMonHoc" Type="String" />

			</Parameters>
		</data:MonKhongTinhDataSource>
		
		<br />

		

</asp:Content>

