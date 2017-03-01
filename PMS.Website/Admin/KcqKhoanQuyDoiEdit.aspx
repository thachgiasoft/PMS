<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqKhoanQuyDoiEdit.aspx.cs" Inherits="KcqKhoanQuyDoiEdit" Title="KcqKhoanQuyDoi Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Khoan Quy Doi - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoan" runat="server" DataSourceID="KcqKhoanQuyDoiDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqKhoanQuyDoiFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqKhoanQuyDoiFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqKhoanQuyDoi not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqKhoanQuyDoiDataSource ID="KcqKhoanQuyDoiDataSource" runat="server"
			SelectMethod="GetByMaKhoan"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoan" QueryStringField="MaKhoan" Type="String" />

			</Parameters>
		</data:KcqKhoanQuyDoiDataSource>
		
		<br />

		

</asp:Content>

