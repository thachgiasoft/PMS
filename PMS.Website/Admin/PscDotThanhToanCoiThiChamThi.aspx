<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="PscDotThanhToanCoiThiChamThi.aspx.cs" Inherits="PscDotThanhToanCoiThiChamThi" Title="PscDotThanhToanCoiThiChamThi List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Psc Dot Thanh Toan Coi Thi Cham Thi List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="PscDotThanhToanCoiThiChamThiDataSource"
				DataKeyNames="MaDot"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_PscDotThanhToanCoiThiChamThi.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="TenDot" HeaderText="Ten Dot" SortExpression="[TenDot]"  />
				<asp:BoundField DataField="MaDot" HeaderText="Ma Dot" SortExpression="[MaDot]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No PscDotThanhToanCoiThiChamThi Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnPscDotThanhToanCoiThiChamThi" OnClientClick="javascript:location.href='PscDotThanhToanCoiThiChamThiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:PscDotThanhToanCoiThiChamThiDataSource ID="PscDotThanhToanCoiThiChamThiDataSource" runat="server"
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
		</data:PscDotThanhToanCoiThiChamThiDataSource>
	    		
</asp:Content>



