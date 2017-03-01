<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="QuyMoKhoaEdit.aspx.cs" Inherits="QuyMoKhoaEdit" Title="QuyMoKhoa Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Quy Mo Khoa - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoa" runat="server" DataSourceID="QuyMoKhoaDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/QuyMoKhoaFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/QuyMoKhoaFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>QuyMoKhoa not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:QuyMoKhoaDataSource ID="QuyMoKhoaDataSource" runat="server"
			SelectMethod="GetByMaKhoa"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoa" QueryStringField="MaKhoa" Type="String" />

			</Parameters>
		</data:QuyMoKhoaDataSource>
		
		<br />

		

</asp:Content>

