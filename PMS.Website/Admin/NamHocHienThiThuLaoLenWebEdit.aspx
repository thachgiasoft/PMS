<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NamHocHienThiThuLaoLenWebEdit.aspx.cs" Inherits="NamHocHienThiThuLaoLenWebEdit" Title="NamHocHienThiThuLaoLenWeb Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nam Hoc Hien Thi Thu Lao Len Web - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="NamHoc, HocKy" runat="server" DataSourceID="NamHocHienThiThuLaoLenWebDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NamHocHienThiThuLaoLenWebFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NamHocHienThiThuLaoLenWebFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NamHocHienThiThuLaoLenWeb not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NamHocHienThiThuLaoLenWebDataSource ID="NamHocHienThiThuLaoLenWebDataSource" runat="server"
			SelectMethod="GetByNamHocHocKy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="NamHoc" QueryStringField="NamHoc" Type="String" />
<asp:QueryStringParameter Name="HocKy" QueryStringField="HocKy" Type="String" />

			</Parameters>
		</data:NamHocHienThiThuLaoLenWebDataSource>
		
		<br />


</asp:Content>

