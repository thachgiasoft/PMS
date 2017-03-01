<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienTamUng.aspx.cs" Inherits="GiangVienTamUng" Title="GiangVienTamUng List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Tam Ung List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienTamUngDataSource"
				DataKeyNames="MaQuanLy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienTamUng.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GioNghiaVuGiangDay" HeaderText="Gio Nghia Vu Giang Day" SortExpression="[GioNghiaVuGiangDay]"  />
				<asp:BoundField DataField="GioNghiaVuNckh" HeaderText="Gio Nghia Vu Nckh" SortExpression="[GioNghiaVuNckh]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="DotThanhToan" HeaderText="Dot Thanh Toan" SortExpression="[DotThanhToan]"  />
				<asp:BoundField DataField="GioGiangDayQuyDoi" HeaderText="Gio Giang Day Quy Doi" SortExpression="[GioGiangDayQuyDoi]"  />
				<asp:BoundField DataField="SoGioQuyDoi" HeaderText="So Gio Quy Doi" SortExpression="[SoGioQuyDoi]"  />
				<asp:BoundField DataField="SoGioQuyDoiKhoiLuongCongThem" HeaderText="So Gio Quy Doi Khoi Luong Cong Them" SortExpression="[SoGioQuyDoiKhoiLuongCongThem]"  />
				<asp:BoundField DataField="GioNckh" HeaderText="Gio Nckh" SortExpression="[GioNckh]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="SoTien" HeaderText="So Tien" SortExpression="[SoTien]"  />
				<asp:BoundField DataField="NgayTamUng" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Tam Ung" SortExpression="[NgayTamUng]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienTamUng Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienTamUng" OnClientClick="javascript:location.href='GiangVienTamUngEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienTamUngDataSource ID="GiangVienTamUngDataSource" runat="server"
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
		</data:GiangVienTamUngDataSource>
	    		
</asp:Content>



