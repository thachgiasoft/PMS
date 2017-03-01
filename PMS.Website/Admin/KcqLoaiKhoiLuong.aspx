<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqLoaiKhoiLuong.aspx.cs" Inherits="KcqLoaiKhoiLuong" Title="KcqLoaiKhoiLuong List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Loai Khoi Luong List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqLoaiKhoiLuongDataSource"
				DataKeyNames="MaLoaiKhoiLuong"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqLoaiKhoiLuong.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="NghiaVu" HeaderText="Nghia Vu" SortExpression="[NghiaVu]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="TenLoaiKhoiLuong" HeaderText="Ten Loai Khoi Luong" SortExpression="[TenLoaiKhoiLuong]"  />
				<asp:BoundField DataField="MaLoaiKhoiLuong" HeaderText="Ma Loai Khoi Luong" SortExpression="[MaLoaiKhoiLuong]" ReadOnly="True" />
				<data:HyperLinkField HeaderText="Ma Nhom" DataNavigateUrlFormatString="KcqNhomKhoiLuongEdit.aspx?MaNhom={0}" DataNavigateUrlFields="MaNhom" DataContainer="MaNhomSource" DataTextField="MaQuanLy" />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqLoaiKhoiLuong Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqLoaiKhoiLuong" OnClientClick="javascript:location.href='KcqLoaiKhoiLuongEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqLoaiKhoiLuongDataSource ID="KcqLoaiKhoiLuongDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KcqLoaiKhoiLuongProperty Name="KcqNhomKhoiLuong"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:KcqLoaiKhoiLuongDataSource>
	    		
</asp:Content>



