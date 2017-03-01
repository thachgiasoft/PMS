<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="VaiTro.aspx.cs" Inherits="VaiTro" Title="VaiTro List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Vai Tro List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="VaiTroDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_VaiTro.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<data:BoundRadioButtonField DataField="Chia" HeaderText="Chia" SortExpression="[Chia]"  />
				<asp:BoundField DataField="MucHuong" HeaderText="Muc Huong" SortExpression="[MucHuong]"  />
				<asp:BoundField DataField="MaVaiTro" HeaderText="Ma Vai Tro" SortExpression="[MaVaiTro]"  />
				<asp:BoundField DataField="TenVaiTro" HeaderText="Ten Vai Tro" SortExpression="[TenVaiTro]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No VaiTro Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnVaiTro" OnClientClick="javascript:location.href='VaiTroEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:VaiTroDataSource ID="VaiTroDataSource" runat="server"
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
		</data:VaiTroDataSource>
	    		
</asp:Content>



