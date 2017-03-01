<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="PscUserConfigApplication.aspx.cs" Inherits="PscUserConfigApplication" Title="PscUserConfigApplication List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Psc User Config Application List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="PscUserConfigApplicationDataSource"
				DataKeyNames="StaffId, ConfigName"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_PscUserConfigApplication.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="StaffId" HeaderText="Staff Id" SortExpression="[StaffID]" ReadOnly="True" />
				<asp:BoundField DataField="ConfigName" HeaderText="Config Name" SortExpression="[ConfigName]" ReadOnly="True" />

			</Columns>
			<EmptyDataTemplate>
				<b>No PscUserConfigApplication Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnPscUserConfigApplication" OnClientClick="javascript:location.href='PscUserConfigApplicationEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:PscUserConfigApplicationDataSource ID="PscUserConfigApplicationDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
		>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:PscUserConfigApplicationDataSource>
	    		
</asp:Content>



