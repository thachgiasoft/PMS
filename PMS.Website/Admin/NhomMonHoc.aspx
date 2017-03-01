<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomMonHoc.aspx.cs" Inherits="NhomMonHoc" Title="NhomMonHoc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Mon Hoc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="NhomMonHocDataSource"
				DataKeyNames="MaNhomMon"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_NhomMonHoc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SiSoNhomThucHanh" HeaderText="Si So Nhom Thuc Hanh" SortExpression="[SiSoNhomThucHanh]"  />
				<asp:BoundField DataField="HeSoQuyDoiThSangLt" HeaderText="He So Quy Doi Th Sang Lt" SortExpression="[HeSoQuyDoiThSangLt]"  />
				<asp:BoundField DataField="MucThanhToan" HeaderText="Muc Thanh Toan" SortExpression="[MucThanhToan]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="TenNhomMon" HeaderText="Ten Nhom Mon" SortExpression="[TenNhomMon]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No NhomMonHoc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnNhomMonHoc" OnClientClick="javascript:location.href='NhomMonHocEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:NhomMonHocDataSource ID="NhomMonHocDataSource" runat="server"
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
		</data:NhomMonHocDataSource>
	    		
</asp:Content>



