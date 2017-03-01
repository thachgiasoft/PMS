<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongCacCongViecKhacEdit.aspx.cs" Inherits="KhoiLuongCacCongViecKhacEdit" Title="KhoiLuongCacCongViecKhac Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Cac Cong Viec Khac - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id, MaLoaiCongViec" runat="server" DataSourceID="KhoiLuongCacCongViecKhacDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongCacCongViecKhacFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KhoiLuongCacCongViecKhacFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KhoiLuongCacCongViecKhac not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KhoiLuongCacCongViecKhacDataSource ID="KhoiLuongCacCongViecKhacDataSource" runat="server"
			SelectMethod="GetByIdMaLoaiCongViec"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />
<asp:QueryStringParameter Name="MaLoaiCongViec" QueryStringField="MaLoaiCongViec" Type="String" />

			</Parameters>
		</data:KhoiLuongCacCongViecKhacDataSource>
		
		<br />


</asp:Content>

