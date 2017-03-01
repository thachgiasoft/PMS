<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiKhoiLuong.aspx.cs" Inherits="LoaiKhoiLuong" Title="LoaiKhoiLuong List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Khoi Luong List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LoaiKhoiLuongDataSource"
				DataKeyNames="MaLoaiKhoiLuong"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LoaiKhoiLuong.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaLoaiKhoiLuong" HeaderText="Ma Loai Khoi Luong" SortExpression="[MaLoaiKhoiLuong]" ReadOnly="True" />
				<data:HyperLinkField HeaderText="Ma Nhom" DataNavigateUrlFormatString="NhomKhoiLuongEdit.aspx?MaNhom={0}" DataNavigateUrlFields="MaNhom" DataContainer="MaNhomSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TenLoaiKhoiLuong" HeaderText="Ten Loai Khoi Luong" SortExpression="[TenLoaiKhoiLuong]"  />
				<data:BoundRadioButtonField DataField="NghiaVu" HeaderText="Nghia Vu" SortExpression="[NghiaVu]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No LoaiKhoiLuong Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLoaiKhoiLuong" OnClientClick="javascript:location.href='LoaiKhoiLuongEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LoaiKhoiLuongDataSource ID="LoaiKhoiLuongDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:LoaiKhoiLuongProperty Name="NhomKhoiLuong"/> 
					<%--<data:LoaiKhoiLuongProperty Name="QuyDoiGioChuanCollection" />--%>
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:LoaiKhoiLuongDataSource>
	    		
</asp:Content>



