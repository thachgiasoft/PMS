<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="UteKhoiLuongQuyDoi.aspx.cs" Inherits="UteKhoiLuongQuyDoi" Title="UteKhoiLuongQuyDoi List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Ute Khoi Luong Quy Doi List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="UteKhoiLuongQuyDoiDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_UteKhoiLuongQuyDoi.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoGioThucGiangTrenLop" HeaderText="So Gio Thuc Giang Tren Lop" SortExpression="[SoGioThucGiangTrenLop]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HeSoHocKy" HeaderText="He So Hoc Ky" SortExpression="[HeSoHocKy]"  />
				<asp:BoundField DataField="SoGioChuanTinhThem" HeaderText="So Gio Chuan Tinh Them" SortExpression="[SoGioChuanTinhThem]"  />
				<asp:BoundField DataField="HeSoLopDongLyThuyet" HeaderText="He So Lop Dong Ly Thuyet" SortExpression="[HeSoLopDongLyThuyet]"  />
				<data:HyperLinkField HeaderText="Id Khoi Luong Giang Day" DataNavigateUrlFormatString="UteKhoiLuongGiangDayEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="IdKhoiLuongGiangDaySource" DataTextField="MaMonHoc" />
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]"  />
				<asp:BoundField DataField="HeSoLopDongThTnTt" HeaderText="He So Lop Dong Th Tn Tt" SortExpression="[HeSoLopDongThTnTt]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No UteKhoiLuongQuyDoi Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnUteKhoiLuongQuyDoi" OnClientClick="javascript:location.href='UteKhoiLuongQuyDoiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:UteKhoiLuongQuyDoiDataSource ID="UteKhoiLuongQuyDoiDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:UteKhoiLuongQuyDoiProperty Name="UteKhoiLuongGiangDay"/> 
					<%--<data:UteKhoiLuongQuyDoiProperty Name="UteThanhToanThuLao" />--%>
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:UteKhoiLuongQuyDoiDataSource>
	    		
</asp:Content>



