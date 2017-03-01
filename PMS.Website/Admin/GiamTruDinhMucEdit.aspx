<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiamTruDinhMucEdit.aspx.cs" Inherits="GiamTruDinhMucEdit" Title="GiamTruDinhMuc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giam Tru Dinh Muc - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaQuanLy" runat="server" DataSourceID="GiamTruDinhMucDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiamTruDinhMucFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiamTruDinhMucFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>GiamTruDinhMuc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:GiamTruDinhMucDataSource ID="GiamTruDinhMucDataSource" runat="server"
			SelectMethod="GetByMaQuanLy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaQuanLy" QueryStringField="MaQuanLy" Type="String" />

			</Parameters>
		</data:GiamTruDinhMucDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewGiangVienGiamTruDinhMuc1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVienGiamTruDinhMuc1_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienGiamTruDinhMucDataSource1"
			DataKeyNames="MaQuanLy"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVienGiamTruDinhMuc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Giam Tru" DataNavigateUrlFormatString="GiamTruDinhMucEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaGiamTruSource" DataTextField="NoiDungGiamTru" />
				<asp:BoundField DataField="PhanTramGiamTru" HeaderText="Phan Tram Giam Tru" SortExpression="[PhanTramGiamTru]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Giam Tru Dinh Muc Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVienGiamTruDinhMuc" NavigateUrl="~/admin/GiangVienGiamTruDinhMucEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienGiamTruDinhMucDataSource ID="GiangVienGiamTruDinhMucDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienGiamTruDinhMucProperty Name="GiamTruDinhMuc"/> 
					<data:GiangVienGiamTruDinhMucProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienGiamTruDinhMucFilter  Column="MaGiamTru" QueryStringField="MaQuanLy" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienGiamTruDinhMucDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewTietNghiaVu2" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewTietNghiaVu2_SelectedIndexChanged"			 			 
			DataSourceID="TietNghiaVuDataSource2"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_TietNghiaVu.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]" />				
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]" />				
				<asp:BoundField DataField="SoTietNghiaVu" HeaderText="So Tiet Nghia Vu" SortExpression="[SoTietNghiaVu]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="TietGioiHan" HeaderText="Tiet Gioi Han" SortExpression="[TietGioiHan]" />				
				<asp:BoundField DataField="GhiChu2" HeaderText="Ghi Chu2" SortExpression="[GhiChu2]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<data:HyperLinkField HeaderText="Ma Giam Tru Khac" DataNavigateUrlFormatString="GiamTruDinhMucEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaGiamTruKhacSource" DataTextField="NoiDungGiamTru" />
				<asp:BoundField DataField="SoTietGiamTruKhac" HeaderText="So Tiet Giam Tru Khac" SortExpression="[SoTietGiamTruKhac]" />				
				<asp:BoundField DataField="TietNghiaVuCongTacKhac" HeaderText="Tiet Nghia Vu Cong Tac Khac" SortExpression="[TietNghiaVuCongTacKhac]" />				
				<asp:BoundField DataField="TietNghiaVuCongTacKhacSauGiamTru" HeaderText="Tiet Nghia Vu Cong Tac Khac Sau Giam Tru" SortExpression="[TietNghiaVuCongTacKhacSauGiamTru]" />				
				<asp:BoundField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]" />				
				<asp:BoundField DataField="TietNghiaVuGiangDay" HeaderText="Tiet Nghia Vu Giang Day" SortExpression="[TietNghiaVuGiangDay]" />				
				<asp:BoundField DataField="TietNghiaVuNckh" HeaderText="Tiet Nghia Vu Nckh" SortExpression="[TietNghiaVuNckh]" />				
				<asp:BoundField DataField="GioChuanGiangDayChuyenSangNckh" HeaderText="Gio Chuan Giang Day Chuyen Sang Nckh" SortExpression="[GioChuanGiangDayChuyenSangNckh]" />				
				<asp:BoundField DataField="TietGiamKhacGiangDay" HeaderText="Tiet Giam Khac Giang Day" SortExpression="[TietGiamKhacGiangDay]" />				
				<asp:BoundField DataField="TietGiamKhacNckh" HeaderText="Tiet Giam Khac Nckh" SortExpression="[TietGiamKhacNckh]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Tiet Nghia Vu Found! </b>
				<asp:HyperLink runat="server" ID="hypTietNghiaVu" NavigateUrl="~/admin/TietNghiaVuEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:TietNghiaVuDataSource ID="TietNghiaVuDataSource2" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:TietNghiaVuProperty Name="GiamTruDinhMuc"/> 
					<data:TietNghiaVuProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:TietNghiaVuFilter  Column="MaGiamTruKhac" QueryStringField="MaQuanLy" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:TietNghiaVuDataSource>		
		
		<br />
		

</asp:Content>

