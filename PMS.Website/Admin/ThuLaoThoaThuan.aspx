<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoThoaThuan.aspx.cs" Inherits="ThuLaoThoaThuan" Title="ThuLaoThoaThuan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Thoa Thuan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoThoaThuanDataSource"
				DataKeyNames="MaThuLao"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoThoaThuan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="MaHeDaoTao" HeaderText="Ma He Dao Tao" SortExpression="[MaHeDaoTao]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoThoaThuan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoThoaThuan" OnClientClick="javascript:location.href='ThuLaoThoaThuanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoThoaThuanDataSource ID="ThuLaoThoaThuanDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ThuLaoThoaThuanProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:ThuLaoThoaThuanDataSource>
	    		
</asp:Content>



