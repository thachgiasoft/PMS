<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqKhoiLuongGiangDayChiTietEdit.aspx.cs" Inherits="KcqKhoiLuongGiangDayChiTietEdit" Title="KcqKhoiLuongGiangDayChiTiet Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Khoi Luong Giang Day Chi Tiet - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaKhoiLuong" runat="server" DataSourceID="KcqKhoiLuongGiangDayChiTietDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqKhoiLuongGiangDayChiTietFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqKhoiLuongGiangDayChiTietFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqKhoiLuongGiangDayChiTiet not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqKhoiLuongGiangDayChiTietDataSource ID="KcqKhoiLuongGiangDayChiTietDataSource" runat="server"
			SelectMethod="GetByMaKhoiLuong"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaKhoiLuong" QueryStringField="MaKhoiLuong" Type="String" />

			</Parameters>
		</data:KcqKhoiLuongGiangDayChiTietDataSource>
		
		<br />

		

</asp:Content>

