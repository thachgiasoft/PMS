<%@ Control Language="C#" ClassName="ThanhToanThinhGiangFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoKhoiNganh" runat="server" Text="He So Khoi Nganh:" AssociatedControlID="dataHeSoKhoiNganh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoKhoiNganh" Text='<%# Bind("HeSoKhoiNganh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoKhoiNganh" runat="server" Display="Dynamic" ControlToValidate="dataHeSoKhoiNganh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLopDong" runat="server" Text="He So Lop Dong:" AssociatedControlID="dataHeSoLopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLopDong" Text='<%# Bind("HeSoLopDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLopDong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLopDong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNgonNgu" runat="server" Text="He So Ngon Ngu:" AssociatedControlID="dataHeSoNgonNgu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNgonNgu" Text='<%# Bind("HeSoNgonNgu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNgonNgu" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNgonNgu" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoBacDaoTao" runat="server" Text="He So Bac Dao Tao:" AssociatedControlID="dataHeSoBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoBacDaoTao" Text='<%# Bind("HeSoBacDaoTao") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoBacDaoTao" runat="server" Display="Dynamic" ControlToValidate="dataHeSoBacDaoTao" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataConNhan" runat="server" Text="Con Nhan:" AssociatedControlID="dataConNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataConNhan" Text='<%# Bind("ConNhan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataConNhan" runat="server" Display="Dynamic" ControlToValidate="dataConNhan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNgoaiGio" runat="server" Text="He So Ngoai Gio:" AssociatedControlID="dataHeSoNgoaiGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNgoaiGio" Text='<%# Bind("HeSoNgoaiGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNgoaiGio" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNgoaiGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayXacNhan" runat="server" Text="Ngay Xac Nhan:" AssociatedControlID="dataNgayXacNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayXacNhan" Text='<%# Bind("NgayXacNhan", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayXacNhan" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoiThucHanhSangLyThuyet" runat="server" Text="He So Quy Doi Thuc Hanh Sang Ly Thuyet:" AssociatedControlID="dataHeSoQuyDoiThucHanhSangLyThuyet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoiThucHanhSangLyThuyet" Text='<%# Bind("HeSoQuyDoiThucHanhSangLyThuyet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoiThucHanhSangLyThuyet" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoiThucHanhSangLyThuyet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoNhomThucHanh" runat="server" Text="Si So Nhom Thuc Hanh:" AssociatedControlID="dataSiSoNhomThucHanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoNhomThucHanh" Text='<%# Bind("SiSoNhomThucHanh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoNhomThucHanh" runat="server" Display="Dynamic" ControlToValidate="dataSiSoNhomThucHanh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietTkb" runat="server" Text="So Tiet Tkb:" AssociatedControlID="dataSoTietTkb" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietTkb" Text='<%# Bind("SoTietTkb") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietTkb" runat="server" Display="Dynamic" ControlToValidate="dataSoTietTkb" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoi" runat="server" Text="Tiet Quy Doi:" AssociatedControlID="dataTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoi" Text='<%# Bind("TietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataXacNhan" runat="server" Text="Xac Nhan:" AssociatedControlID="dataXacNhan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataXacNhan" SelectedValue='<%# Bind("XacNhan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayNhap" runat="server" Text="Ngay Nhap:" AssociatedControlID="dataNgayNhap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayNhap" Text='<%# Bind("NgayNhap", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayNhap" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChucDanh" runat="server" Text="Chuc Danh:" AssociatedControlID="dataChucDanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChucDanh" Text='<%# Bind("ChucDanh") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataStt" runat="server" Text="Stt:" AssociatedControlID="dataStt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataStt" Text='<%# Bind("Stt") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataStt" runat="server" Display="Dynamic" ControlToValidate="dataStt" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSo" runat="server" Text="Si So:" AssociatedControlID="dataSiSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSo" Text='<%# Bind("SiSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSo" runat="server" Display="Dynamic" ControlToValidate="dataSiSo" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
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
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCongHeSo" runat="server" Text="Cong He So:" AssociatedControlID="dataCongHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCongHeSo" Text='<%# Bind("CongHeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCongHeSo" runat="server" Display="Dynamic" ControlToValidate="dataCongHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThue" runat="server" Text="Thue:" AssociatedControlID="dataThue" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThue" Text='<%# Bind("Thue") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThue" runat="server" Display="Dynamic" ControlToValidate="dataThue" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTien" runat="server" Text="Thanh Tien:" AssociatedControlID="dataThanhTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTien" Text='<%# Bind("ThanhTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTien" runat="server" Display="Dynamic" ControlToValidate="dataThanhTien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDung" runat="server" Text="Noi Dung:" AssociatedControlID="dataNoiDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDung" Text='<%# Bind("NoiDung") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoChucDanh" runat="server" Text="He So Chuc Danh:" AssociatedControlID="dataHeSoChucDanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoChucDanh" Text='<%# Bind("HeSoChucDanh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoChucDanh" runat="server" Display="Dynamic" ControlToValidate="dataHeSoChucDanh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


