<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DanhMucHoatDongQuanLyEdit.aspx.cs" Inherits="DanhMucHoatDongQuanLyEdit" Title="DanhMucHoatDongQuanLy Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Danh Muc Hoat Dong Quan Ly - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="DanhMucHoatDongQuanLyDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DanhMucHoatDongQuanLyFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/DanhMucHoatDongQuanLyFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>DanhMucHoatDongQuanLy not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:DanhMucHoatDongQuanLyDataSource ID="DanhMucHoatDongQuanLyDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:DanhMucHoatDongQuanLyDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewNoiDungCongViecQuanLy1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewNoiDungCongViecQuanLy1_SelectedIndexChanged"			 			 
			DataSourceID="NoiDungCongViecQuanLyDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_NoiDungCongViecQuanLy.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Cong Viec" DataNavigateUrlFormatString="DanhMucHoatDongQuanLyEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaCongViecSource" DataTextField="MaHoatDong" />
				<asp:BoundField DataField="NoiDung" HeaderText="Noi Dung" SortExpression="[NoiDung]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Noi Dung Cong Viec Quan Ly Found! </b>
				<asp:HyperLink runat="server" ID="hypNoiDungCongViecQuanLy" NavigateUrl="~/admin/NoiDungCongViecQuanLyEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:NoiDungCongViecQuanLyDataSource ID="NoiDungCongViecQuanLyDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:NoiDungCongViecQuanLyProperty Name="DanhMucHoatDongQuanLy"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:NoiDungCongViecQuanLyFilter  Column="MaCongViec" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:NoiDungCongViecQuanLyDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVienHoatDongQuanLy2" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienHoatDongQuanLy2_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienHoatDongQuanLyDataSource2"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienHoatDongQuanLy.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Hoat Dong Quan Ly" DataNavigateUrlFormatString="DanhMucHoatDongQuanLyEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaHoatDongQuanLySource" DataTextField="MaHoatDong" />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]" />				
				<asp:BoundField DataField="NoiDungCongViec" HeaderText="Noi Dung Cong Viec" SortExpression="[NoiDungCongViec]" />				
				<asp:BoundField DataField="NgayThucHien" HeaderText="Ngay Thuc Hien" SortExpression="[NgayThucHien]" />				
				<asp:BoundField DataField="SoPhut" HeaderText="So Phut" SortExpression="[SoPhut]" />				
				<asp:BoundField DataField="HeSoQuyDoi" HeaderText="He So Quy Doi" SortExpression="[HeSoQuyDoi]" />				
				<asp:BoundField DataField="XacNhan" HeaderText="Xac Nhan" SortExpression="[XacNhan]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Hoat Dong Quan Ly Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienHoatDongQuanLy" NavigateUrl="~/admin/GiangVienHoatDongQuanLyEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienHoatDongQuanLyDataSource ID="GiangVienHoatDongQuanLyDataSource2" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienHoatDongQuanLyProperty Name="DanhMucHoatDongQuanLy"/> 
					<data:GiangVienHoatDongQuanLyProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienHoatDongQuanLyFilter  Column="MaHoatDongQuanLy" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienHoatDongQuanLyDataSource>		
		
		<br />
		

</asp:Content>

