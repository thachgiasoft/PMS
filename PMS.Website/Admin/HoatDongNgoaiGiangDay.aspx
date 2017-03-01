<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HoatDongNgoaiGiangDay.aspx.cs" Inherits="HoatDongNgoaiGiangDay" Title="HoatDongNgoaiGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Hoat Dong Ngoai Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HoatDongNgoaiGiangDayDataSource"
				DataKeyNames="MaQuanLy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HoatDongNgoaiGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<data:HyperLinkField HeaderText="Ma Nhom" DataNavigateUrlFormatString="NhomHoatDongNgoaiGiangDayEdit.aspx?MaNhom={0}" DataNavigateUrlFields="MaNhom" DataContainer="MaNhomSource" DataTextField="TenNhom" />
				<asp:BoundField DataField="MucQuyDoi" HeaderText="Muc Quy Doi" SortExpression="[MucQuyDoi]"  />
				<asp:BoundField DataField="TenHoatDong" HeaderText="Ten Hoat Dong" SortExpression="[TenHoatDong]"  />
				<asp:BoundField DataField="MaDonViTinh" HeaderText="Ma Don Vi Tinh" SortExpression="[MaDonViTinh]"  />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No HoatDongNgoaiGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHoatDongNgoaiGiangDay" OnClientClick="javascript:location.href='HoatDongNgoaiGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HoatDongNgoaiGiangDayDataSource ID="HoatDongNgoaiGiangDayDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:HoatDongNgoaiGiangDayProperty Name="NhomHoatDongNgoaiGiangDay"/> 
					<%--<data:HoatDongNgoaiGiangDayProperty Name="GiangVienHoatDongNgoaiGiangDayCollection" />--%>
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:HoatDongNgoaiGiangDayDataSource>
	    		
</asp:Content>



