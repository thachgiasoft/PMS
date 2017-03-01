<%@ Control Language="C#" ClassName="KhoiLuongCacCongViecKhacFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoi" runat="server" Text="He So Quy Doi:" AssociatedControlID="dataHeSoQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoi" Text='<%# Bind("HeSoQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoi" runat="server" Text="Tiet Quy Doi:" AssociatedControlID="dataTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoi" Text='<%# Bind("TietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhom" runat="server" Text="Ma Nhom:" AssociatedControlID="dataMaNhom" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhom" Text='<%# Bind("MaNhom") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChot" runat="server" Text="Chot:" AssociatedControlID="dataChot" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataChot" SelectedValue='<%# Bind("Chot") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoChucDanhKhoiLuongKhac" runat="server" Text="He So Chuc Danh Khoi Luong Khac:" AssociatedControlID="dataHeSoChucDanhKhoiLuongKhac" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoChucDanhKhoiLuongKhac" Text='<%# Bind("HeSoChucDanhKhoiLuongKhac") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoChucDanhKhoiLuongKhac" runat="server" Display="Dynamic" ControlToValidate="dataHeSoChucDanhKhoiLuongKhac" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotThanhToan" runat="server" Text="Dot Thanh Toan:" AssociatedControlID="dataDotThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotThanhToan" Text='<%# Bind("DotThanhToan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiCongViec" runat="server" Text="Ma Loai Cong Viec:" AssociatedControlID="dataMaLoaiCongViec" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaLoaiCongViec" DataSourceID="MaLoaiCongViecQuyDoiGioChuanDataSource" DataTextField="MaQuanLy" DataValueField="MaQuyDoi" SelectedValue='<%# Bind("MaLoaiCongViec") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:QuyDoiGioChuanDataSource ID="MaLoaiCongViecQuyDoiGioChuanDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDonViTinh" runat="server" Text="Ma Don Vi Tinh:" AssociatedControlID="dataMaDonViTinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDonViTinh" Text='<%# Bind("MaDonViTinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaDonViTinh" runat="server" Display="Dynamic" ControlToValidate="dataMaDonViTinh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioChuanCongThemTrenMotTiet" runat="server" Text="Gio Chuan Cong Them Tren Mot Tiet:" AssociatedControlID="dataGioChuanCongThemTrenMotTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioChuanCongThemTrenMotTiet" Text='<%# Bind("GioChuanCongThemTrenMotTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioChuanCongThemTrenMotTiet" runat="server" Display="Dynamic" ControlToValidate="dataGioChuanCongThemTrenMotTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoLuong" runat="server" Text="So Luong:" AssociatedControlID="dataSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLuong" Text='<%# Bind("SoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataSoLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNhan" runat="server" Text="He So Nhan:" AssociatedControlID="dataHeSoNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNhan" Text='<%# Bind("HeSoNhan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNhan" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNhan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


