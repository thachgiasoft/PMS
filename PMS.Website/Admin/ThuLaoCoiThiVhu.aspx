<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoCoiThiVhu.aspx.cs" Inherits="ThuLaoCoiThiVhu" Title="ThuLaoCoiThiVhu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Coi Thi Vhu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoCoiThiVhuDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoCoiThiVhu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoTietQuyDoi" HeaderText="So Tiet Quy Doi" SortExpression="[SoTietQuyDoi]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HeSoQuyDoi" HeaderText="He So Quy Doi" SortExpression="[HeSoQuyDoi]"  />
				<asp:BoundField DataField="ThuLaoCoiThi120" HeaderText="Thu Lao Coi Thi120" SortExpression="[ThuLaoCoiThi120]"  />
				<asp:BoundField DataField="TongCong" HeaderText="Tong Cong" SortExpression="[TongCong]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<data:BoundRadioButtonField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]"  />
				<asp:BoundField DataField="LanThi" HeaderText="Lan Thi" SortExpression="[LanThi]"  />
				<asp:BoundField DataField="KyThi" HeaderText="Ky Thi" SortExpression="[KyThi]"  />
				<asp:BoundField DataField="MaGiangVienQuanLy" HeaderText="Ma Giang Vien Quan Ly" SortExpression="[MaGiangVienQuanLy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="ThuLaoCoiThi90" HeaderText="Thu Lao Coi Thi90" SortExpression="[ThuLaoCoiThi90]"  />
				<asp:BoundField DataField="SoBuoiCoiThi120" HeaderText="So Buoi Coi Thi120" SortExpression="[SoBuoiCoiThi120]"  />
				<asp:BoundField DataField="SoBuoiCoiThi90" HeaderText="So Buoi Coi Thi90" SortExpression="[SoBuoiCoiThi90]"  />
				<asp:BoundField DataField="SoBuoiCoiThi75" HeaderText="So Buoi Coi Thi75" SortExpression="[SoBuoiCoiThi75]"  />
				<asp:BoundField DataField="ThuLaoCoiThi75" HeaderText="Thu Lao Coi Thi75" SortExpression="[ThuLaoCoiThi75]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoCoiThiVhu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoCoiThiVhu" OnClientClick="javascript:location.href='ThuLaoCoiThiVhuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoCoiThiVhuDataSource ID="ThuLaoCoiThiVhuDataSource" runat="server"
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
		</data:ThuLaoCoiThiVhuDataSource>
	    		
</asp:Content>



