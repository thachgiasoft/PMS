<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LopHocPhanBacDaoTaoEdit.aspx.cs" Inherits="LopHocPhanBacDaoTaoEdit" Title="LopHocPhanBacDaoTao Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Lop Hoc Phan Bac Dao Tao - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLopHocPhan, MaHeSoBacDaoTao" runat="server" DataSourceID="LopHocPhanBacDaoTaoDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopHocPhanBacDaoTaoFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LopHocPhanBacDaoTaoFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LopHocPhanBacDaoTao not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LopHocPhanBacDaoTaoDataSource ID="LopHocPhanBacDaoTaoDataSource" runat="server"
			SelectMethod="GetByMaLopHocPhanMaHeSoBacDaoTao"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLopHocPhan" QueryStringField="MaLopHocPhan" Type="String" />
<asp:QueryStringParameter Name="MaHeSoBacDaoTao" QueryStringField="MaHeSoBacDaoTao" Type="String" />

			</Parameters>
		</data:LopHocPhanBacDaoTaoDataSource>
		
		<br />


</asp:Content>

