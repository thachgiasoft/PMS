<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoRaDeVhu.aspx.cs" Inherits="ThuLaoRaDeVhu" Title="ThuLaoRaDeVhu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Ra De Vhu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoRaDeVhuDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoRaDeVhu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoTietQuyDoi" HeaderText="So Tiet Quy Doi" SortExpression="[SoTietQuyDoi]"  />
				<asp:BoundField DataField="TongTien" HeaderText="Tong Tien" SortExpression="[TongTien]"  />
				<asp:BoundField DataField="HeSoQuyDoi" HeaderText="He So Quy Doi" SortExpression="[HeSoQuyDoi]"  />
				<asp:BoundField DataField="TenDangDeThi" HeaderText="Ten Dang De Thi" SortExpression="[TenDangDeThi]"  />
				<asp:BoundField DataField="KyThi" HeaderText="Ky Thi" SortExpression="[KyThi]"  />
				<data:BoundRadioButtonField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="MaDotThi" HeaderText="Ma Dot Thi" SortExpression="[MaDotThi]"  />
				<asp:BoundField DataField="TenDotThi" HeaderText="Ten Dot Thi" SortExpression="[TenDotThi]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="ThoiGianLamBai" HeaderText="Thoi Gian Lam Bai" SortExpression="[ThoiGianLamBai]"  />
				<asp:BoundField DataField="HeSoExamination" HeaderText="He So Examination" SortExpression="[HeSoExamination]"  />
				<asp:BoundField DataField="MaDangDeThi" HeaderText="Ma Dang De Thi" SortExpression="[MaDangDeThi]"  />
				<asp:BoundField DataField="SoLuongDe" HeaderText="So Luong De" SortExpression="[SoLuongDe]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="MaHinhThucThi" HeaderText="Ma Hinh Thuc Thi" SortExpression="[MaHinhThucThi]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoRaDeVhu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoRaDeVhu" OnClientClick="javascript:location.href='ThuLaoRaDeVhuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoRaDeVhuDataSource ID="ThuLaoRaDeVhuDataSource" runat="server"
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
		</data:ThuLaoRaDeVhuDataSource>
	    		
</asp:Content>



