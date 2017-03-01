﻿<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqHeSoDiaDiemEdit.aspx.cs" Inherits="KcqHeSoDiaDiemEdit" Title="KcqHeSoDiaDiem Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq He So Dia Diem - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaHeSo" runat="server" DataSourceID="KcqHeSoDiaDiemDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqHeSoDiaDiemFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/KcqHeSoDiaDiemFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>KcqHeSoDiaDiem not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:KcqHeSoDiaDiemDataSource ID="KcqHeSoDiaDiemDataSource" runat="server"
			SelectMethod="GetByMaHeSo"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaHeSo" QueryStringField="MaHeSo" Type="String" />

			</Parameters>
		</data:KcqHeSoDiaDiemDataSource>
		
		<br />

		

</asp:Content>
