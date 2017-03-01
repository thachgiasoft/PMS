<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqLoaiKhoiLuongEdit.aspx.cs" Inherits="KcqLoaiKhoiLuongEdit" Title="KcqLoaiKhoiLuong Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Loai Khoi Luong - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLoaiKhoiLuong" runat="server" DataSourceID="KcqLoaiKhoiLuongDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqLoaiKhoiLuongFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqLoaiKhoiLuongFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqLoaiKhoiLuong not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqLoaiKhoiLuongDataSource ID="KcqLoaiKhoiLuongDataSource" runat="server"
			SelectMethod="GetByMaLoaiKhoiLuong"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLoaiKhoiLuong" QueryStringField="MaLoaiKhoiLuong" Type="String" />

			</Parameters>
		</data:KcqLoaiKhoiLuongDataSource>
		
		<br />

		

</asp:Content>

