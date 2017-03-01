<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuMoiGiangHopDongThinhGiang.aspx.cs" Inherits="ThuMoiGiangHopDongThinhGiang" Title="ThuMoiGiangHopDongThinhGiang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Moi Giang Hop Dong Thinh Giang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuMoiGiangHopDongThinhGiangDataSource"
				DataKeyNames="MaGiangVien, MaLopHocPhan, MaLopSinhVien"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuMoiGiangHopDongThinhGiang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]"  />
				<asp:BoundField DataField="HeSoTinChi" HeaderText="He So Tin Chi" SortExpression="[HeSoTinChi]"  />
				<asp:BoundField DataField="HeSoLd" HeaderText="He So Ld" SortExpression="[HeSoLD]"  />
				<asp:BoundField DataField="NgayBatDauDay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Bat Dau Day" SortExpression="[NgayBatDauDay]"  />
				<data:BoundRadioButtonField DataField="HoanTat" HeaderText="Hoan Tat" SortExpression="[HoanTat]"  />
				<asp:BoundField DataField="MaLopSinhVien" HeaderText="Ma Lop Sinh Vien" SortExpression="[MaLopSinhVien]" ReadOnly="True" />
				<asp:BoundField DataField="NgayKetThucDay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Ket Thuc Day" SortExpression="[NgayKetThucDay]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" ReadOnly="True" />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]" ReadOnly="True" />
				<asp:BoundField DataField="MaLoaiHinh" HeaderText="Ma Loai Hinh" SortExpression="[MaLoaiHinh]"  />
				<asp:BoundField DataField="SiSoLop" HeaderText="Si So Lop" SortExpression="[SiSoLop]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuMoiGiangHopDongThinhGiang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuMoiGiangHopDongThinhGiang" OnClientClick="javascript:location.href='ThuMoiGiangHopDongThinhGiangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuMoiGiangHopDongThinhGiangDataSource ID="ThuMoiGiangHopDongThinhGiangDataSource" runat="server"
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
		</data:ThuMoiGiangHopDongThinhGiangDataSource>
	    		
</asp:Content>



