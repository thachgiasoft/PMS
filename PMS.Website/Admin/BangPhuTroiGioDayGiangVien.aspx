<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="BangPhuTroiGioDayGiangVien.aspx.cs" Inherits="BangPhuTroiGioDayGiangVien" Title="BangPhuTroiGioDayGiangVien List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Bang Phu Troi Gio Day Giang Vien List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="BangPhuTroiGioDayGiangVienDataSource"
				DataKeyNames="MaGiangVien"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_BangPhuTroiGioDayGiangVien.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]" ReadOnly="True" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="Ho" HeaderText="Ho" SortExpression="[Ho]"  />
				<asp:BoundField DataField="Ten" HeaderText="Ten" SortExpression="[Ten]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaDonVi" HeaderText="Ma Don Vi" SortExpression="[MaDonVi]"  />
				<asp:BoundField DataField="TenDonVi" HeaderText="Ten Don Vi" SortExpression="[TenDonVi]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="TenLoaiGiangVien" HeaderText="Ten Loai Giang Vien" SortExpression="[TenLoaiGiangVien]"  />
				<asp:BoundField DataField="TcThucDay" HeaderText="Tc Thuc Day" SortExpression="[TCThucDay]"  />
				<asp:BoundField DataField="TietQd" HeaderText="Tiet Qd" SortExpression="[TietQD]"  />
				<asp:BoundField DataField="NhiemVuGd" HeaderText="Nhiem Vu Gd" SortExpression="[NhiemVuGD]"  />
				<asp:BoundField DataField="NhiemVuNckh" HeaderText="Nhiem Vu Nckh" SortExpression="[NhiemVuNCKH]"  />
				<asp:BoundField DataField="PhanCongCn" HeaderText="Phan Cong Cn" SortExpression="[PhanCongCN]"  />
				<asp:BoundField DataField="CongTrinhCd" HeaderText="Cong Trinh Cd" SortExpression="[CongTrinhCD]"  />
				<asp:BoundField DataField="CongTrinhTc" HeaderText="Cong Trinh Tc" SortExpression="[CongTrinhTC]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No BangPhuTroiGioDayGiangVien Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnBangPhuTroiGioDayGiangVien" OnClientClick="javascript:location.href='BangPhuTroiGioDayGiangVienEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:BangPhuTroiGioDayGiangVienDataSource ID="BangPhuTroiGioDayGiangVienDataSource" runat="server"
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
		</data:BangPhuTroiGioDayGiangVienDataSource>
	    		
</asp:Content>



