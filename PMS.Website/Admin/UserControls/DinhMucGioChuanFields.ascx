<%@ Control Language="C#" ClassName="DinhMucGioChuanFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataTongDinhMuc" runat="server" Text="Tong Dinh Muc:" AssociatedControlID="dataTongDinhMuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongDinhMuc" Text='<%# Bind("TongDinhMuc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongDinhMuc" runat="server" Display="Dynamic" ControlToValidate="dataTongDinhMuc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuHeSoLuong" runat="server" Text="Tu He So Luong:" AssociatedControlID="dataTuHeSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuHeSoLuong" Text='<%# Bind("TuHeSoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTuHeSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataTuHeSoLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDenHeSoLuong" runat="server" Text="Den He So Luong:" AssociatedControlID="dataDenHeSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDenHeSoLuong" Text='<%# Bind("DenHeSoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDenHeSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataDenHeSoLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanLoaiGiangVien" runat="server" Text="Phan Loai Giang Vien:" AssociatedControlID="dataPhanLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanLoaiGiangVien" Text='<%# Bind("PhanLoaiGiangVien") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucMonHoc" runat="server" Text="Dinh Muc Mon Hoc:" AssociatedControlID="dataDinhMucMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucMonHoc" Text='<%# Bind("DinhMucMonHoc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucMonHoc" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucMonHoc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataStt" runat="server" Text="Stt:" AssociatedControlID="dataStt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataStt" Text='<%# Bind("Stt") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataStt" runat="server" Display="Dynamic" ControlToValidate="dataStt" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucMonGdtcQp" runat="server" Text="Dinh Muc Mon Gdtc Qp:" AssociatedControlID="dataDinhMucMonGdtcQp" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucMonGdtcQp" Text='<%# Bind("DinhMucMonGdtcQp") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucMonGdtcQp" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucMonGdtcQp" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBacLuong" runat="server" Text="Ma Bac Luong:" AssociatedControlID="dataMaBacLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBacLuong" Text='<%# Bind("MaBacLuong") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucHoatDongChuyenMonKhac" runat="server" Text="Dinh Muc Hoat Dong Chuyen Mon Khac:" AssociatedControlID="dataDinhMucHoatDongChuyenMonKhac" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucHoatDongChuyenMonKhac" Text='<%# Bind("DinhMucHoatDongChuyenMonKhac") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucHoatDongChuyenMonKhac" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucHoatDongChuyenMonKhac" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucNckh" runat="server" Text="Dinh Muc Nckh:" AssociatedControlID="dataDinhMucNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucNckh" Text='<%# Bind("DinhMucNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucNckh" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucNckh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLuongTangThem" runat="server" Text="He So Luong Tang Them:" AssociatedControlID="dataHeSoLuongTangThem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLuongTangThem" Text='<%# Bind("HeSoLuongTangThem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLuongTangThem" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLuongTangThem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


