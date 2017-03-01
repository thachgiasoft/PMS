<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="TietNghiaVu.aspx.cs" Inherits="TietNghiaVu" Title="TietNghiaVu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Tiet Nghia Vu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="TietNghiaVuDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_TietNghiaVu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TietNghiaVuCongTacKhacSauGiamTru" HeaderText="Tiet Nghia Vu Cong Tac Khac Sau Giam Tru" SortExpression="[TietNghiaVuCongTacKhacSauGiamTru]"  />
				<data:BoundRadioButtonField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]"  />
				<asp:BoundField DataField="TietNghiaVuCongTacKhac" HeaderText="Tiet Nghia Vu Cong Tac Khac" SortExpression="[TietNghiaVuCongTacKhac]"  />
				<data:HyperLinkField HeaderText="Ma Giam Tru Khac" DataNavigateUrlFormatString="GiamTruDinhMucEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaGiamTruKhacSource" DataTextField="NoiDungGiamTru" />
				<asp:BoundField DataField="SoTietGiamTruKhac" HeaderText="So Tiet Giam Tru Khac" SortExpression="[SoTietGiamTruKhac]"  />
				<asp:BoundField DataField="TietGiamKhacGiangDay" HeaderText="Tiet Giam Khac Giang Day" SortExpression="[TietGiamKhacGiangDay]"  />
				<asp:BoundField DataField="TietGiamKhacNckh" HeaderText="Tiet Giam Khac Nckh" SortExpression="[TietGiamKhacNckh]"  />
				<asp:BoundField DataField="GioChuanGiangDayChuyenSangNckh" HeaderText="Gio Chuan Giang Day Chuyen Sang Nckh" SortExpression="[GioChuanGiangDayChuyenSangNckh]"  />
				<asp:BoundField DataField="TietNghiaVuGiangDay" HeaderText="Tiet Nghia Vu Giang Day" SortExpression="[TietNghiaVuGiangDay]"  />
				<asp:BoundField DataField="TietNghiaVuNckh" HeaderText="Tiet Nghia Vu Nckh" SortExpression="[TietNghiaVuNckh]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="TietGioiHan" HeaderText="Tiet Gioi Han" SortExpression="[TietGioiHan]"  />
				<asp:BoundField DataField="GhiChu2" HeaderText="Ghi Chu2" SortExpression="[GhiChu2]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="SoTietNghiaVu" HeaderText="So Tiet Nghia Vu" SortExpression="[SoTietNghiaVu]"  />
				<data:BoundRadioButtonField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No TietNghiaVu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnTietNghiaVu" OnClientClick="javascript:location.href='TietNghiaVuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:TietNghiaVuDataSource ID="TietNghiaVuDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:TietNghiaVuProperty Name="GiamTruDinhMuc"/> 
					<data:TietNghiaVuProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:TietNghiaVuDataSource>
	    		
</asp:Content>



