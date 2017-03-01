<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LopHocPhanGhepThoiKhoaBieu.aspx.cs" Inherits="LopHocPhanGhepThoiKhoaBieu" Title="LopHocPhanGhepThoiKhoaBieu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Lop Hoc Phan Ghep Thoi Khoa Bieu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="LopHocPhanGhepThoiKhoaBieuDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_LopHocPhanGhepThoiKhoaBieu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="LopChinh" HeaderText="Lop Chinh" SortExpression="[LopChinh]"  />
				<asp:BoundField DataField="MaLopSauGhep" HeaderText="Ma Lop Sau Ghep" SortExpression="[MaLopSauGhep]"  />
				<asp:BoundField DataField="MaLopTruocGhep" HeaderText="Ma Lop Truoc Ghep" SortExpression="[MaLopTruocGhep]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="SiSoSauGhep" HeaderText="Si So Sau Ghep" SortExpression="[SiSoSauGhep]"  />
				<asp:BoundField DataField="MaCanBoGiangDay" HeaderText="Ma Can Bo Giang Day" SortExpression="[MaCanBoGiangDay]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="SoThuTu" HeaderText="So Thu Tu" SortExpression="[SoThuTu]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="SiSoTruocGhep" HeaderText="Si So Truoc Ghep" SortExpression="[SiSoTruocGhep]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No LopHocPhanGhepThoiKhoaBieu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnLopHocPhanGhepThoiKhoaBieu" OnClientClick="javascript:location.href='LopHocPhanGhepThoiKhoaBieuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:LopHocPhanGhepThoiKhoaBieuDataSource ID="LopHocPhanGhepThoiKhoaBieuDataSource" runat="server"
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
		</data:LopHocPhanGhepThoiKhoaBieuDataSource>
	    		
</asp:Content>



