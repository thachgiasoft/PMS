<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThongTinGiangDayGiangVien.aspx.cs" Inherits="ThongTinGiangDayGiangVien" Title="ThongTinGiangDayGiangVien List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thong Tin Giang Day Giang Vien List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThongTinGiangDayGiangVienDataSource"
				DataKeyNames="MaGiangVien, MaLopHocPhan"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThongTinGiangDayGiangVien.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="ChiPhiDiLai" HeaderText="Chi Phi Di Lai" SortExpression="[ChiPhiDiLai]"  />
				<asp:BoundField DataField="ChiPhiLuuTru" HeaderText="Chi Phi Luu Tru" SortExpression="[ChiPhiLuuTru]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" ReadOnly="True" />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]" ReadOnly="True" />
				<asp:BoundField DataField="SoNgayLuuTru" HeaderText="So Ngay Luu Tru" SortExpression="[SoNgayLuuTru]"  />
				<asp:BoundField DataField="SoLanDiLai" HeaderText="So Lan Di Lai" SortExpression="[SoLanDiLai]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThongTinGiangDayGiangVien Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThongTinGiangDayGiangVien" OnClientClick="javascript:location.href='ThongTinGiangDayGiangVienEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThongTinGiangDayGiangVienDataSource ID="ThongTinGiangDayGiangVienDataSource" runat="server"
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
		</data:ThongTinGiangDayGiangVienDataSource>
	    		
</asp:Content>



