<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThanhTraGiangDayEdit.aspx.cs" Inherits="ThanhTraGiangDayEdit" Title="ThanhTraGiangDay Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thanh Tra Giang Day - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHoSoThanhTra" runat="server" DataSourceID="ThanhTraGiangDayDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThanhTraGiangDayFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/ThanhTraGiangDayFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>ThanhTraGiangDay not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:ThanhTraGiangDayDataSource ID="ThanhTraGiangDayDataSource" runat="server"
			SelectMethod="GetByMaHoSoThanhTra"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHoSoThanhTra" QueryStringField="MaHoSoThanhTra" Type="String" />

			</Parameters>
		</data:ThanhTraGiangDayDataSource>
		
		<br />

		

</asp:Content>

