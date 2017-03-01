<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DanhMucViPham.aspx.cs" Inherits="DanhMucViPham" Title="DanhMucViPham List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Danh Muc Vi Pham List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DanhMucViPhamDataSource"
				DataKeyNames="MaViPham"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DanhMucViPham.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="CoXepLoai" HeaderText="Co Xep Loai" SortExpression="[CoXepLoai]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaViPham" HeaderText="Ma Vi Pham" SortExpression="[MaViPham]" ReadOnly="True" />
				<asp:BoundField DataField="NoiDungViPham" HeaderText="Noi Dung Vi Pham" SortExpression="[NoiDungViPham]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DanhMucViPham Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDanhMucViPham" OnClientClick="javascript:location.href='DanhMucViPhamEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DanhMucViPhamDataSource ID="DanhMucViPhamDataSource" runat="server"
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
		</data:DanhMucViPhamDataSource>
	    		
</asp:Content>



