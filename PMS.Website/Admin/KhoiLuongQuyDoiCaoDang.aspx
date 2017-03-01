<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongQuyDoiCaoDang.aspx.cs" Inherits="KhoiLuongQuyDoiCaoDang" Title="KhoiLuongQuyDoiCaoDang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Quy Doi Cao Dang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KhoiLuongQuyDoiCaoDangDataSource"
				DataKeyNames="MaKhoiLuongQuyDoiCaoDang"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KhoiLuongQuyDoiCaoDang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TietQuyDoiLt" HeaderText="Tiet Quy Doi Lt" SortExpression="[TietQuyDoiLT]"  />
				<asp:BoundField DataField="TietQuyDoiTh" HeaderText="Tiet Quy Doi Th" SortExpression="[TietQuyDoiTH]"  />
				<asp:BoundField DataField="TongTietQuyDoi" HeaderText="Tong Tiet Quy Doi" SortExpression="[TongTietQuyDoi]"  />
				<data:HyperLinkField HeaderText="Ma Khoi Luong Cao Dang" DataNavigateUrlFormatString="KhoiLuongGiangDayCaoDangEdit.aspx?MaKhoiLuongCaoDang={0}" DataNavigateUrlFields="MaKhoiLuongCaoDang" DataContainer="MaKhoiLuongCaoDangSource" DataTextField="MaGiangVienQuanLy" />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KhoiLuongQuyDoiCaoDang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKhoiLuongQuyDoiCaoDang" OnClientClick="javascript:location.href='KhoiLuongQuyDoiCaoDangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KhoiLuongQuyDoiCaoDangDataSource ID="KhoiLuongQuyDoiCaoDangDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoiLuongQuyDoiCaoDangProperty Name="KhoiLuongGiangDayCaoDang"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:KhoiLuongQuyDoiCaoDangDataSource>
	    		
</asp:Content>



