<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuMoiGiangHopDongThinhGiangEdit.aspx.cs" Inherits="ThuMoiGiangHopDongThinhGiangEdit" Title="ThuMoiGiangHopDongThinhGiang Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Moi Giang Hop Dong Thinh Giang - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaGiangVien, MaLopHocPhan, MaLopSinhVien" runat="server" DataSourceID="ThuMoiGiangHopDongThinhGiangDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThuMoiGiangHopDongThinhGiangFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThuMoiGiangHopDongThinhGiangFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>ThuMoiGiangHopDongThinhGiang not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:ThuMoiGiangHopDongThinhGiangDataSource ID="ThuMoiGiangHopDongThinhGiangDataSource" runat="server"
			SelectMethod="GetByMaGiangVienMaLopHocPhanMaLopSinhVien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaGiangVien" QueryStringField="MaGiangVien" Type="String" />
<asp:QueryStringParameter Name="MaLopHocPhan" QueryStringField="MaLopHocPhan" Type="String" />
<asp:QueryStringParameter Name="MaLopSinhVien" QueryStringField="MaLopSinhVien" Type="String" />

			</Parameters>
		</data:ThuMoiGiangHopDongThinhGiangDataSource>
		
		<br />


</asp:Content>

