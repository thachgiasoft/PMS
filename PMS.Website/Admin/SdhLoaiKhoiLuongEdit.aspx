<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="SdhLoaiKhoiLuongEdit.aspx.cs" Inherits="SdhLoaiKhoiLuongEdit" Title="SdhLoaiKhoiLuong Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Sdh Loai Khoi Luong - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLoaiKhoiLuong" runat="server" DataSourceID="SdhLoaiKhoiLuongDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/SdhLoaiKhoiLuongFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/SdhLoaiKhoiLuongFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>SdhLoaiKhoiLuong not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:SdhLoaiKhoiLuongDataSource ID="SdhLoaiKhoiLuongDataSource" runat="server"
			SelectMethod="GetByMaLoaiKhoiLuong"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLoaiKhoiLuong" QueryStringField="MaLoaiKhoiLuong" Type="String" />

			</Parameters>
		</data:SdhLoaiKhoiLuongDataSource>
		
		<br />

		

</asp:Content>

