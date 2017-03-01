<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienHoatDongNgoaiGiangDayEdit.aspx.cs" Inherits="GiangVienHoatDongNgoaiGiangDayEdit" Title="GiangVienHoatDongNgoaiGiangDay Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Hoat Dong Ngoai Giang Day - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaQuanLy" runat="server" DataSourceID="GiangVienHoatDongNgoaiGiangDayDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienHoatDongNgoaiGiangDayFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/GiangVienHoatDongNgoaiGiangDayFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>GiangVienHoatDongNgoaiGiangDay not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:GiangVienHoatDongNgoaiGiangDayDataSource ID="GiangVienHoatDongNgoaiGiangDayDataSource" runat="server"
			SelectMethod="GetByMaQuanLy"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaQuanLy" QueryStringField="MaQuanLy" Type="String" />

			</Parameters>
		</data:GiangVienHoatDongNgoaiGiangDayDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewQuyDoiHoatDongNgoaiGiangDay1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewQuyDoiHoatDongNgoaiGiangDay1_SelectedIndexChanged"			 			 
			DataSourceID="QuyDoiHoatDongNgoaiGiangDayDataSource1"
			DataKeyNames="MaQuanLy"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_QuyDoiHoatDongNgoaiGiangDay.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Ma Hoat Dong Ngoai Giang Day" DataNavigateUrlFormatString="GiangVienHoatDongNgoaiGiangDayEdit.aspx?MaQuanLy={0}" DataNavigateUrlFields="MaQuanLy" DataContainer="MaHoatDongNgoaiGiangDaySource" DataTextField="NamHoc" />
				<asp:BoundField DataField="SoTietQuyDoi" HeaderText="So Tiet Quy Doi" SortExpression="[SoTietQuyDoi]" />				
				<asp:BoundField DataField="SoTien" HeaderText="So Tien" SortExpression="[SoTien]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Quy Doi Hoat Dong Ngoai Giang Day Found! </b>
				<asp:HyperLink runat="server" ID="hypQuyDoiHoatDongNgoaiGiangDay" NavigateUrl="~/admin/QuyDoiHoatDongNgoaiGiangDayEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:QuyDoiHoatDongNgoaiGiangDayDataSource ID="QuyDoiHoatDongNgoaiGiangDayDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:QuyDoiHoatDongNgoaiGiangDayProperty Name="GiangVienHoatDongNgoaiGiangDay"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:QuyDoiHoatDongNgoaiGiangDayFilter  Column="MaHoatDongNgoaiGiangDay" QueryStringField="MaQuanLy" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:QuyDoiHoatDongNgoaiGiangDayDataSource>		
		
		<br />
		

</asp:Content>

