<%@ Control Language="C#" ClassName="KhoiLuongGiangDayTungTuanFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaToaNha" runat="server" Text="Ma Toa Nha:" AssociatedControlID="dataMaToaNha" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaToaNha" Text='<%# Bind("MaToaNha") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhom" runat="server" Text="Ma Nhom:" AssociatedControlID="dataMaNhom" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhom" Text='<%# Bind("MaNhom") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiHocPhan" runat="server" Text="Loai Hoc Phan:" AssociatedControlID="dataLoaiHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiHocPhan" Text='<%# Bind("LoaiHocPhan") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanLoai" runat="server" Text="Phan Loai:" AssociatedControlID="dataPhanLoai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanLoai" Text='<%# Bind("PhanLoai") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDienGiai" runat="server" Text="Dien Giai:" AssociatedControlID="dataDienGiai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDienGiai" Text='<%# Bind("DienGiai") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTinChi" runat="server" Text="So Tin Chi:" AssociatedControlID="dataSoTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTinChi" Text='<%# Bind("SoTinChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataSoTinChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoLop" runat="server" Text="Si So Lop:" AssociatedControlID="dataSiSoLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoLop" Text='<%# Bind("SiSoLop") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoLop" runat="server" Display="Dynamic" ControlToValidate="dataSiSoLop" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoNhom" runat="server" Text="So Nhom:" AssociatedControlID="dataSoNhom" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoNhom" Text='<%# Bind("SoNhom") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoNhom" runat="server" Display="Dynamic" ControlToValidate="dataSoNhom" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDiaDiem" runat="server" Text="Ma Dia Diem:" AssociatedControlID="dataMaDiaDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDiaDiem" Text='<%# Bind("MaDiaDiem") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayBatDau" runat="server" Text="Ngay Bat Dau:" AssociatedControlID="dataNgayBatDau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayBatDau" Text='<%# Bind("NgayBatDau", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayBatDau" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayKetThuc" runat="server" Text="Ngay Ket Thuc:" AssociatedControlID="dataNgayKetThuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayKetThuc" Text='<%# Bind("NgayKetThuc", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayKetThuc" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChatLuongCao" runat="server" Text="Chat Luong Cao:" AssociatedControlID="dataChatLuongCao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChatLuongCao" Text='<%# Bind("ChatLuongCao") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataChatLuongCao" runat="server" Display="Dynamic" ControlToValidate="dataChatLuongCao" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgoaiGio" runat="server" Text="Ngoai Gio:" AssociatedControlID="dataNgoaiGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgoaiGio" Text='<%# Bind("NgoaiGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataNgoaiGio" runat="server" Display="Dynamic" ControlToValidate="dataNgoaiGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTrongGio" runat="server" Text="Trong Gio:" AssociatedControlID="dataTrongGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTrongGio" Text='<%# Bind("TrongGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTrongGio" runat="server" Display="Dynamic" ControlToValidate="dataTrongGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLopDong" runat="server" Text="He So Lop Dong:" AssociatedControlID="dataHeSoLopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLopDong" Text='<%# Bind("HeSoLopDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLopDong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLopDong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoCoSo" runat="server" Text="He So Co So:" AssociatedControlID="dataHeSoCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoCoSo" Text='<%# Bind("HeSoCoSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoCoSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSoCoSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoHocKy" runat="server" Text="He So Hoc Ky:" AssociatedControlID="dataHeSoHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoHocKy" Text='<%# Bind("HeSoHocKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoHocKy" runat="server" Display="Dynamic" ControlToValidate="dataHeSoHocKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoThanhPhan" runat="server" Text="He So Thanh Phan:" AssociatedControlID="dataHeSoThanhPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoThanhPhan" Text='<%# Bind("HeSoThanhPhan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoThanhPhan" runat="server" Display="Dynamic" ControlToValidate="dataHeSoThanhPhan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoTrongGio" runat="server" Text="He So Trong Gio:" AssociatedControlID="dataHeSoTrongGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoTrongGio" Text='<%# Bind("HeSoTrongGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoTrongGio" runat="server" Display="Dynamic" ControlToValidate="dataHeSoTrongGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNgoaiGio" runat="server" Text="He So Ngoai Gio:" AssociatedControlID="dataHeSoNgoaiGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNgoaiGio" Text='<%# Bind("HeSoNgoaiGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNgoaiGio" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNgoaiGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoi" runat="server" Text="Tiet Quy Doi:" AssociatedControlID="dataTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoi" Text='<%# Bind("TietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiHocKy" runat="server" Text="Loai Hoc Ky:" AssociatedControlID="dataLoaiHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiHocKy" Text='<%# Bind("LoaiHocKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataLoaiHocKy" runat="server" Display="Dynamic" ControlToValidate="dataLoaiHocKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiKhoaBieu" runat="server" Text="Thoi Khoa Bieu:" AssociatedControlID="dataThoiKhoaBieu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiKhoaBieu" Text='<%# Bind("ThoiKhoaBieu") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayTao" runat="server" Text="Ngay Tao:" AssociatedControlID="dataNgayTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayTao" Text='<%# Bind("NgayTao", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayTao" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuan" runat="server" Text="Tuan:" AssociatedControlID="dataTuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuan" Text='<%# Bind("Tuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTuan" runat="server" Display="Dynamic" ControlToValidate="dataTuan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNam" runat="server" Text="Nam:" AssociatedControlID="dataNam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNam" Text='<%# Bind("Nam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataNam" runat="server" Display="Dynamic" ControlToValidate="dataNam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayDay" runat="server" Text="Ngay Day:" AssociatedControlID="dataNgayDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayDay" Text='<%# Bind("NgayDay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayDay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


