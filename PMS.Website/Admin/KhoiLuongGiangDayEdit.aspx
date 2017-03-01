<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongGiangDayEdit.aspx.cs" Inherits="KhoiLuongGiangDayEdit" Title="KhoiLuongGiangDay Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Giang Day - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoiLuong" runat="server" DataSourceID="KhoiLuongGiangDayDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongGiangDayFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongGiangDayFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KhoiLuongGiangDay not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KhoiLuongGiangDayDataSource ID="KhoiLuongGiangDayDataSource" runat="server"
			SelectMethod="GetByMaKhoiLuong"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoiLuong" QueryStringField="MaKhoiLuong" Type="String" />

			</Parameters>
		</data:KhoiLuongGiangDayDataSource>
		
		<br />

		

</asp:Content>

