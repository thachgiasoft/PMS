<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoThuLao.aspx.cs" Inherits="HeSoThuLao" Title="HeSoThuLao List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Thu Lao List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HeSoThuLaoDataSource"
				DataKeyNames="MaThuLao"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HeSoThuLao.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TenHeSoThuLao" HeaderText="Ten He So Thu Lao" SortExpression="[TenHeSoThuLao]"  />
				<asp:BoundField DataField="HeSoThuLao" HeaderText="He So Thu Lao" SortExpression="[HeSoThuLao]"  />
				<asp:BoundField DataField="MaThuLao" HeaderText="Ma Thu Lao" SortExpression="[MaThuLao]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No HeSoThuLao Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHeSoThuLao" OnClientClick="javascript:location.href='HeSoThuLaoEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HeSoThuLaoDataSource ID="HeSoThuLaoDataSource" runat="server"
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
		</data:HeSoThuLaoDataSource>
	    		
</asp:Content>



