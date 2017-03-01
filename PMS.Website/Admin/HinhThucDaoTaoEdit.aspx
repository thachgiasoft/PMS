<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HinhThucDaoTaoEdit.aspx.cs" Inherits="HinhThucDaoTaoEdit" Title="HinhThucDaoTao Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Hinh Thuc Dao Tao - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHinhThucDaoTao" runat="server" DataSourceID="HinhThucDaoTaoDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HinhThucDaoTaoFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/HinhThucDaoTaoFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>HinhThucDaoTao not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:HinhThucDaoTaoDataSource ID="HinhThucDaoTaoDataSource" runat="server"
			SelectMethod="GetByMaHinhThucDaoTao"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHinhThucDaoTao" QueryStringField="MaHinhThucDaoTao" Type="String" />

			</Parameters>
		</data:HinhThucDaoTaoDataSource>
		
		<br />

		

</asp:Content>

