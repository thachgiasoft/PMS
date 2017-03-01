<%@ Control Language="C#" ClassName="GiangVienNghienCuuKhFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioGiangChuyenSangNckh" runat="server" Text="Gio Giang Chuyen Sang Nckh:" AssociatedControlID="dataGioGiangChuyenSangNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioGiangChuyenSangNckh" Text='<%# Bind("GioGiangChuyenSangNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioGiangChuyenSangNckh" runat="server" Display="Dynamic" ControlToValidate="dataGioGiangChuyenSangNckh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayNhap" runat="server" Text="Ngay Nhap:" AssociatedControlID="dataNgayNhap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayNhap" Text='<%# Bind("NgayNhap", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayNhap" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucDoHoanThanh" runat="server" Text="Muc Do Hoan Thanh:" AssociatedControlID="dataMucDoHoanThanh" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMucDoHoanThanh" DataSourceID="MucDoHoanThanhMucDoHoanThanhNckhDataSource" DataTextField="MaQuanLy" DataValueField="Id" SelectedValue='<%# Bind("MucDoHoanThanh") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:MucDoHoanThanhNckhDataSource ID="MucDoHoanThanhMucDoHoanThanhNckhDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenNckh" runat="server" Text="Ten Nckh:" AssociatedControlID="dataTenNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenNckh" Text='<%# Bind("TenNckh") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoLuongThanhVien" runat="server" Text="So Luong Thanh Vien:" AssociatedControlID="dataSoLuongThanhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLuongThanhVien" Text='<%# Bind("SoLuongThanhVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLuongThanhVien" runat="server" Display="Dynamic" ControlToValidate="dataSoLuongThanhVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataXacNhan" runat="server" Text="Xac Nhan:" AssociatedControlID="dataXacNhan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataXacNhan" SelectedValue='<%# Bind("XacNhan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayXacNhan" runat="server" Text="Ngay Xac Nhan:" AssociatedControlID="dataNgayXacNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayXacNhan" Text='<%# Bind("NgayXacNhan", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayXacNhan" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaVaiTro" runat="server" Text="Ma Vai Tro:" AssociatedControlID="dataMaVaiTro" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaVaiTro" DataSourceID="MaVaiTroVaiTroDataSource" DataTextField="MaVaiTro" DataValueField="Id" SelectedValue='<%# Bind("MaVaiTro") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:VaiTroDataSource ID="MaVaiTroVaiTroDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDuKien" runat="server" Text="Du Kien:" AssociatedControlID="dataDuKien" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDuKien" SelectedValue='<%# Bind("DuKien") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiangVien" DataSourceID="MaGiangVienGiangVienDataSource" DataTextField="MaDanToc" DataValueField="MaGiangVien" SelectedValue='<%# Bind("MaGiangVien") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:GiangVienDataSource ID="MaGiangVienGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNckh" runat="server" Text="Ma Nckh:" AssociatedControlID="dataMaNckh" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaNckh" DataSourceID="MaNckhDanhMucNghienCuuKhoaHocDataSource" DataTextField="MaQuanLy" DataValueField="Id" SelectedValue='<%# Bind("MaNckh") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:DanhMucNghienCuuKhoaHocDataSource ID="MaNckhDanhMucNghienCuuKhoaHocDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayHieuLuc" runat="server" Text="Ngay Hieu Luc:" AssociatedControlID="dataNgayHieuLuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayHieuLuc" Text='<%# Bind("NgayHieuLuc") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTrangThai" runat="server" Text="Trang Thai:" AssociatedControlID="dataTrangThai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTrangThai" SelectedValue='<%# Bind("TrangThai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayHetHieuLuc" runat="server" Text="Ngay Het Hieu Luc:" AssociatedControlID="dataNgayHetHieuLuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayHetHieuLuc" Text='<%# Bind("NgayHetHieuLuc") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


