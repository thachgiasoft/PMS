<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqUteThanhToanThuLaoEdit.aspx.cs" Inherits="KcqUteThanhToanThuLaoEdit" Title="KcqUteThanhToanThuLao Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Ute Thanh Toan Thu Lao - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="IdKhoiLuongQuyDoi" runat="server" DataSourceID="KcqUteThanhToanThuLaoDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqUteThanhToanThuLaoFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqUteThanhToanThuLaoFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqUteThanhToanThuLao not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqUteThanhToanThuLaoDataSource ID="KcqUteThanhToanThuLaoDataSource" runat="server"
			SelectMethod="GetByIdKhoiLuongQuyDoi"
		>
			<Parameters>
				<asp:QueryStringParameter Name="IdKhoiLuongQuyDoi" QueryStringField="IdKhoiLuongQuyDoi" Type="String" />

			</Parameters>
		</data:KcqUteThanhToanThuLaoDataSource>
		
		<br />

		

</asp:Content>

