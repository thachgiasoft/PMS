<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqKhoiLuongKhacEdit.aspx.cs" Inherits="KcqKhoiLuongKhacEdit" Title="KcqKhoiLuongKhac Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Khoi Luong Khac - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoiLuong" runat="server" DataSourceID="KcqKhoiLuongKhacDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqKhoiLuongKhacFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqKhoiLuongKhacFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqKhoiLuongKhac not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqKhoiLuongKhacDataSource ID="KcqKhoiLuongKhacDataSource" runat="server"
			SelectMethod="GetByMaKhoiLuong"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoiLuong" QueryStringField="MaKhoiLuong" Type="String" />

			</Parameters>
		</data:KcqKhoiLuongKhacDataSource>
		
		<br />

		

</asp:Content>

