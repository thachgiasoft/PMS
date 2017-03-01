<%@ Control Language="C#" ClassName="GiangVienHoatDongQuanLyFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayThucHien" runat="server" Text="Ngay Thuc Hien:" AssociatedControlID="dataNgayThucHien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayThucHien" Text='<%# Bind("NgayThucHien", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayThucHien" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDungCongViec" runat="server" Text="Noi Dung Cong Viec:" AssociatedControlID="dataNoiDungCongViec" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDungCongViec" Text='<%# Bind("NoiDungCongViec") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChot" runat="server" Text="Chot:" AssociatedControlID="dataChot" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataChot" SelectedValue='<%# Bind("Chot") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataXacNhan" runat="server" Text="Xac Nhan:" AssociatedControlID="dataXacNhan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataXacNhan" SelectedValue='<%# Bind("XacNhan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoi" runat="server" Text="He So Quy Doi:" AssociatedControlID="dataHeSoQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoi" Text='<%# Bind("HeSoQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoPhut" runat="server" Text="So Phut:" AssociatedControlID="dataSoPhut" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoPhut" Text='<%# Bind("SoPhut") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoPhut" runat="server" Display="Dynamic" ControlToValidate="dataSoPhut" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiangVien" DataSourceID="MaGiangVienGiangVienDataSource" DataTextField="MaDanToc" DataValueField="MaGiangVien" SelectedValue='<%# Bind("MaGiangVien") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:GiangVienDataSource ID="MaGiangVienGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHoatDongQuanLy" runat="server" Text="Ma Hoat Dong Quan Ly:" AssociatedControlID="dataMaHoatDongQuanLy" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHoatDongQuanLy" DataSourceID="MaHoatDongQuanLyDanhMucHoatDongQuanLyDataSource" DataTextField="MaHoatDong" DataValueField="Id" SelectedValue='<%# Bind("MaHoatDongQuanLy") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:DanhMucHoatDongQuanLyDataSource ID="MaHoatDongQuanLyDanhMucHoatDongQuanLyDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


