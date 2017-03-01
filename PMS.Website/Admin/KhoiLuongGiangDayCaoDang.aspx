<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KhoiLuongGiangDayCaoDang.aspx.cs" Inherits="KhoiLuongGiangDayCaoDang" Title="KhoiLuongGiangDayCaoDang List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Khoi Luong Giang Day Cao Dang List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KhoiLuongGiangDayCaoDangDataSource"
				DataKeyNames="MaKhoiLuongCaoDang"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KhoiLuongGiangDayCaoDang.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaGiangVienQuanLy" HeaderText="Ma Giang Vien Quan Ly" SortExpression="[MaGiangVienQuanLy]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="SiSoLop" HeaderText="Si So Lop" SortExpression="[SiSoLop]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="TietThucDayLt" HeaderText="Tiet Thuc Day Lt" SortExpression="[TietThucDayLT]"  />
				<asp:BoundField DataField="TietThucDayTh" HeaderText="Tiet Thuc Day Th" SortExpression="[TietThucDayTH]"  />
				<data:HyperLinkField HeaderText="Ma Cau Hinh Chot Gio" DataNavigateUrlFormatString="CauHinhChotGioEdit.aspx?MaCauHinhChotGio={0}" DataNavigateUrlFields="MaCauHinhChotGio" DataContainer="MaCauHinhChotGioSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TenLopHocPhan" HeaderText="Ten Lop Hoc Phan" SortExpression="[TenLopHocPhan]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KhoiLuongGiangDayCaoDang Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKhoiLuongGiangDayCaoDang" OnClientClick="javascript:location.href='KhoiLuongGiangDayCaoDangEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KhoiLuongGiangDayCaoDangDataSource ID="KhoiLuongGiangDayCaoDangDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KhoiLuongGiangDayCaoDangProperty Name="CauHinhChotGio"/> 
					<%--<data:KhoiLuongGiangDayCaoDangProperty Name="KhoiLuongQuyDoiCaoDangCollection" />--%>
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:KhoiLuongGiangDayCaoDangDataSource>
	    		
</asp:Content>



