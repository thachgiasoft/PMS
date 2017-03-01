<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChiTienThuLaoGiangDay.aspx.cs" Inherits="ChiTienThuLaoGiangDay" Title="ChiTienThuLaoGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chi Tien Thu Lao Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ChiTienThuLaoGiangDayDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ChiTienThuLaoGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayLayDuLieu" HeaderText="Ngay Lay Du Lieu" SortExpression="[NgayLayDuLieu]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<data:BoundRadioButtonField DataField="LopClc" HeaderText="Lop Clc" SortExpression="[LopClc]"  />
				<asp:BoundField DataField="MaLopSinhVien" HeaderText="Ma Lop Sinh Vien" SortExpression="[MaLopSinhVien]"  />
				<asp:BoundField DataField="TongSoTietQuyDoi" HeaderText="Tong So Tiet Quy Doi" SortExpression="[TongSoTietQuyDoi]"  />
				<asp:BoundField DataField="MaCanBoGiangDay" HeaderText="Ma Can Bo Giang Day" SortExpression="[MaCanBoGiangDay]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="Oid" HeaderText="Oid" SortExpression="[Oid]"  />
				<asp:BoundField DataField="SoChungTuHrm" HeaderText="So Chung Tu Hrm" SortExpression="[SoChungTuHrm]"  />
				<asp:BoundField DataField="TongTien" HeaderText="Tong Tien" SortExpression="[TongTien]"  />
				<data:BoundRadioButtonField DataField="LaGiangVienThinhGiang" HeaderText="La Giang Vien Thinh Giang" SortExpression="[LaGiangVienThinhGiang]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ChiTienThuLaoGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnChiTienThuLaoGiangDay" OnClientClick="javascript:location.href='ChiTienThuLaoGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ChiTienThuLaoGiangDayDataSource ID="ChiTienThuLaoGiangDayDataSource" runat="server"
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
		</data:ChiTienThuLaoGiangDayDataSource>
	    		
</asp:Content>



