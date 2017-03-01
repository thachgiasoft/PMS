<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqCauHinhChotGioEdit.aspx.cs" Inherits="KcqCauHinhChotGioEdit" Title="KcqCauHinhChotGio Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Cau Hinh Chot Gio - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaCauHinhChotGio" runat="server" DataSourceID="KcqCauHinhChotGioDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqCauHinhChotGioFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqCauHinhChotGioFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqCauHinhChotGio not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqCauHinhChotGioDataSource ID="KcqCauHinhChotGioDataSource" runat="server"
			SelectMethod="GetByMaCauHinhChotGio"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaCauHinhChotGio" QueryStringField="MaCauHinhChotGio" Type="String" />

			</Parameters>
		</data:KcqCauHinhChotGioDataSource>
		
		<br />

		

</asp:Content>

