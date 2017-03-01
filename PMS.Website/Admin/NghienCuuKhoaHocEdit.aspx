<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NghienCuuKhoaHocEdit.aspx.cs" Inherits="NghienCuuKhoaHocEdit" Title="NghienCuuKhoaHoc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nghien Cuu Khoa Hoc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNghienCuuKhoaHoc" runat="server" DataSourceID="NghienCuuKhoaHocDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NghienCuuKhoaHocFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NghienCuuKhoaHocFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NghienCuuKhoaHoc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NghienCuuKhoaHocDataSource ID="NghienCuuKhoaHocDataSource" runat="server"
			SelectMethod="GetByMaNghienCuuKhoaHoc"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNghienCuuKhoaHoc" QueryStringField="MaNghienCuuKhoaHoc" Type="String" />

			</Parameters>
		</data:NghienCuuKhoaHocDataSource>
		
		<br />

		

</asp:Content>

