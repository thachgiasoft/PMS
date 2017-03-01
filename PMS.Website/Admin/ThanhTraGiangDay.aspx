<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThanhTraGiangDay.aspx.cs" Inherits="ThanhTraGiangDay" Title="ThanhTraGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thanh Tra Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThanhTraGiangDayDataSource"
				DataKeyNames="MaHoSoThanhTra"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThanhTraGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaHienThi" HeaderText="Ma Hien Thi" SortExpression="[MaHienThi]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="Khoa" HeaderText="Khoa" SortExpression="[Khoa]"  />
				<asp:BoundField DataField="LoaiGiangVien" HeaderText="Loai Giang Vien" SortExpression="[LoaiGiangVien]"  />
				<asp:BoundField DataField="TenHocPhan" HeaderText="Ten Hoc Phan" SortExpression="[TenHocPhan]"  />
				<asp:BoundField DataField="TinhHinhGhiNhan" HeaderText="Tinh Hinh Ghi Nhan" SortExpression="[TinhHinhGhiNhan]"  />
				<asp:BoundField DataField="Ngay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay" SortExpression="[Ngay]"  />
				<asp:BoundField DataField="Tiet" HeaderText="Tiet" SortExpression="[Tiet]"  />
				<asp:BoundField DataField="Lop" HeaderText="Lop" SortExpression="[Lop]"  />
				<asp:BoundField DataField="Phong" HeaderText="Phong" SortExpression="[Phong]"  />
				<asp:BoundField DataField="ThoiDiemGhiNhan" HeaderText="Thoi Diem Ghi Nhan" SortExpression="[ThoiDiemGhiNhan]"  />
				<asp:BoundField DataField="LyDo" HeaderText="Ly Do" SortExpression="[LyDo]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaHinhThucViPham" HeaderText="Ma Hinh Thuc Vi Pham" SortExpression="[MaHinhThucViPham]"  />
				<data:BoundRadioButtonField DataField="DaBaoSuaTkb" HeaderText="Da Bao Sua Tkb" SortExpression="[DaBaoSuaTkb]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThanhTraGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThanhTraGiangDay" OnClientClick="javascript:location.href='ThanhTraGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThanhTraGiangDayDataSource ID="ThanhTraGiangDayDataSource" runat="server"
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
		</data:ThanhTraGiangDayDataSource>
	    		
</asp:Content>



