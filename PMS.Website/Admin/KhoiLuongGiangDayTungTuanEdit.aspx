<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongGiangDayTungTuanEdit.aspx.cs" Inherits="KhoiLuongGiangDayTungTuanEdit" Title="KhoiLuongGiangDayTungTuan Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Giang Day Tung Tuan - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoiLuong" runat="server" DataSourceID="KhoiLuongGiangDayTungTuanDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongGiangDayTungTuanFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongGiangDayTungTuanFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KhoiLuongGiangDayTungTuan not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KhoiLuongGiangDayTungTuanDataSource ID="KhoiLuongGiangDayTungTuanDataSource" runat="server"
			SelectMethod="GetByMaKhoiLuong"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoiLuong" QueryStringField="MaKhoiLuong" Type="String" />

			</Parameters>
		</data:KhoiLuongGiangDayTungTuanDataSource>
		
		<br />

		

</asp:Content>

