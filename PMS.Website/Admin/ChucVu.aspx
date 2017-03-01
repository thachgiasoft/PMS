<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChucVu.aspx.cs" Inherits="ChucVu" Title="ChucVu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chuc Vu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ChucVuDataSource"
				DataKeyNames="MaChucVu"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ChucVu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayBdApDung" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Bd Ap Dung" SortExpression="[NgayBDApDung]"  />
				<asp:BoundField DataField="NgayKtApDung" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Kt Ap Dung" SortExpression="[NgayKTApDung]"  />
				<data:BoundRadioButtonField DataField="CongDonKiemNhiem" HeaderText="Cong Don Kiem Nhiem" SortExpression="[CongDonKiemNhiem]"  />
				<asp:BoundField DataField="DinhMucToiThieu" HeaderText="Dinh Muc Toi Thieu" SortExpression="[DinhMucToiThieu]"  />
				<asp:BoundField DataField="Hrmid" HeaderText="Hrmid" SortExpression="[Hrmid]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="TenChucVu" HeaderText="Ten Chuc Vu" SortExpression="[TenChucVu]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="PhanTramGio" HeaderText="Phan Tram Gio" SortExpression="[PhanTramGio]"  />
				<asp:BoundField DataField="NguongTiet" HeaderText="Nguong Tiet" SortExpression="[NguongTiet]"  />
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ChucVu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnChucVu" OnClientClick="javascript:location.href='ChucVuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ChucVuDataSource ID="ChucVuDataSource" runat="server"
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
		</data:ChucVuDataSource>
	    		
</asp:Content>



