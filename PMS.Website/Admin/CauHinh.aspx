<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="CauHinh.aspx.cs" Inherits="CauHinh" Title="CauHinh List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Cau Hinh List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="CauHinhDataSource"
				DataKeyNames="MaCauHinh"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_CauHinh.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ChucVuKeToan" HeaderText="Chuc Vu Ke Toan" SortExpression="[ChucVuKeToan]"  />
				<asp:BoundField DataField="ChucVuDaoTao" HeaderText="Chuc Vu Dao Tao" SortExpression="[ChucVuDaoTao]"  />
				<asp:BoundField DataField="ChucVuDaiDienHopDongThinhGiang" HeaderText="Chuc Vu Dai Dien Hop Dong Thinh Giang" SortExpression="[ChucVuDaiDienHopDongThinhGiang]"  />
				<asp:BoundField DataField="ChucVuDaiDienHopDongThinhGiang02" HeaderText="Chuc Vu Dai Dien Hop Dong Thinh Giang02" SortExpression="[ChucVuDaiDienHopDongThinhGiang02]"  />
				<asp:BoundField DataField="DiaChiDaiDien" HeaderText="Dia Chi Dai Dien" SortExpression="[DiaChiDaiDien]"  />
				<asp:BoundField DataField="ChucVuKhoa" HeaderText="Chuc Vu Khoa" SortExpression="[ChucVuKhoa]"  />
				<asp:BoundField DataField="ChucVuToChucCanBo" HeaderText="Chuc Vu To Chuc Can Bo" SortExpression="[ChucVuToChucCanBo]"  />
				<asp:BoundField DataField="DienThoaiDaiDien" HeaderText="Dien Thoai Dai Dien" SortExpression="[DienThoaiDaiDien]"  />
				<asp:BoundField DataField="FaxDaiDien" HeaderText="Fax Dai Dien" SortExpression="[FaxDaiDien]"  />
				<asp:BoundField DataField="ChucVuKeHoachTaiChinh" HeaderText="Chuc Vu Ke Hoach Tai Chinh" SortExpression="[ChucVuKeHoachTaiChinh]"  />
				<asp:BoundField DataField="DaiDienHopDongThinhGiang" HeaderText="Dai Dien Hop Dong Thinh Giang" SortExpression="[DaiDienHopDongThinhGiang]"  />
				<asp:BoundField DataField="ChucVuBanGiamHieu" HeaderText="Chuc Vu Ban Giam Hieu" SortExpression="[ChucVuBanGiamHieu]"  />
				<asp:BoundField DataField="TenTruong" HeaderText="Ten Truong" SortExpression="[TenTruong]"  />
				<asp:BoundField DataField="PhongDaoTao" HeaderText="Phong Dao Tao" SortExpression="[PhongDaoTao]"  />
				<asp:BoundField DataField="NguoiLapbieu" HeaderText="Nguoi Lapbieu" SortExpression="[NguoiLapbieu]"  />
				<data:BoundRadioButtonField DataField="TrangThai" HeaderText="Trang Thai" SortExpression="[TrangThai]"  />
				<asp:BoundField DataField="PhongToChucCanBo" HeaderText="Phong To Chuc Can Bo" SortExpression="[PhongToChucCanBo]"  />
				<asp:BoundField DataField="PhongKeHoachTaiChinh" HeaderText="Phong Ke Hoach Tai Chinh" SortExpression="[PhongKeHoachTaiChinh]"  />
				<asp:BoundField DataField="BanGiamHieu" HeaderText="Ban Giam Hieu" SortExpression="[BanGiamHieu]"  />
				<asp:BoundField DataField="KeToan" HeaderText="Ke Toan" SortExpression="[KeToan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No CauHinh Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnCauHinh" OnClientClick="javascript:location.href='CauHinhEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:CauHinhDataSource ID="CauHinhDataSource" runat="server"
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
		</data:CauHinhDataSource>
	    		
</asp:Content>



