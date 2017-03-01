<%@ Control Language="C#" ClassName="ChietTinhBoiDuongGiangDayFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataNamHoc" runat="server" Display="Dynamic" ControlToValidate="dataNamHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataHocKy" runat="server" Display="Dynamic" ControlToValidate="dataHocKy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopSinhVien" runat="server" Text="Ma Lop Sinh Vien:" AssociatedControlID="dataMaLopSinhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopSinhVien" Text='<%# Bind("MaLopSinhVien") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLopSinhVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLopSinhVien" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongCong" runat="server" Text="Tong Cong:" AssociatedControlID="dataTongCong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongCong" Text='<%# Bind("TongCong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongCong" runat="server" Display="Dynamic" ControlToValidate="dataTongCong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoi" runat="server" Text="Tiet Quy Doi:" AssociatedControlID="dataTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoi" Text='<%# Bind("TietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTienThem" runat="server" Text="Tien Them:" AssociatedControlID="dataTienThem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTienThem" Text='<%# Bind("TienThem") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataTienThem" runat="server" Display="Dynamic" ControlToValidate="dataTienThem" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataTienThem" runat="server" Display="Dynamic" ControlToValidate="dataTienThem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChiPhiLuuTru" runat="server" Text="Chi Phi Luu Tru:" AssociatedControlID="dataChiPhiLuuTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChiPhiLuuTru" Text='<%# Bind("ChiPhiLuuTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataChiPhiLuuTru" runat="server" Display="Dynamic" ControlToValidate="dataChiPhiLuuTru" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChiPhiDiLai" runat="server" Text="Chi Phi Di Lai:" AssociatedControlID="dataChiPhiDiLai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChiPhiDiLai" Text='<%# Bind("ChiPhiDiLai") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataChiPhiDiLai" runat="server" Display="Dynamic" ControlToValidate="dataChiPhiDiLai" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoDeThiDapAn" runat="server" Text="So De Thi Dap An:" AssociatedControlID="dataSoDeThiDapAn" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoDeThiDapAn" Text='<%# Bind("SoDeThiDapAn") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoDeThiDapAn" runat="server" Display="Dynamic" ControlToValidate="dataSoDeThiDapAn" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoNgayLuuTru" runat="server" Text="So Ngay Luu Tru:" AssociatedControlID="dataSoNgayLuuTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoNgayLuuTru" Text='<%# Bind("SoNgayLuuTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoNgayLuuTru" runat="server" Display="Dynamic" ControlToValidate="dataSoNgayLuuTru" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLopSinhVien" runat="server" Text="Ten Lop Sinh Vien:" AssociatedControlID="dataTenLopSinhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLopSinhVien" Text='<%# Bind("TenLopSinhVien") %>' MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataTenLopSinhVien" runat="server" Display="Dynamic" ControlToValidate="dataTenLopSinhVien" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHoanTat" runat="server" Text="Hoan Tat:" AssociatedControlID="dataHoanTat" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataHoanTat" SelectedValue='<%# Bind("HoanTat") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoLanDiLai" runat="server" Text="So Lan Di Lai:" AssociatedControlID="dataSoLanDiLai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLanDiLai" Text='<%# Bind("SoLanDiLai") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLanDiLai" runat="server" Display="Dynamic" ControlToValidate="dataSoLanDiLai" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaPhong" runat="server" Text="Ma Phong:" AssociatedControlID="dataMaPhong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaPhong" Text='<%# Bind("MaPhong") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenPhong" runat="server" Text="Ten Phong:" AssociatedControlID="dataTenPhong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenPhong" Text='<%# Bind("TenPhong") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaCoSo" runat="server" Text="Ma Co So:" AssociatedControlID="dataMaCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaCoSo" Text='<%# Bind("MaCoSo") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLopHocPhan" runat="server" Text="Ten Lop Hoc Phan:" AssociatedControlID="dataTenLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLopHocPhan" Text='<%# Bind("TenLopHocPhan") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaQuanLy" runat="server" Display="Dynamic" ControlToValidate="dataMaQuanLy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHoTen" runat="server" Text="Ho Ten:" AssociatedControlID="dataHoTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHoTen" Text='<%# Bind("HoTen") %>' MaxLength="152"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="30"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLopHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLopHocPhan" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoLop" runat="server" Text="Si So Lop:" AssociatedControlID="dataSiSoLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoLop" Text='<%# Bind("SiSoLop") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoLop" runat="server" Display="Dynamic" ControlToValidate="dataSiSoLop" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLd" runat="server" Text="He So Ld:" AssociatedControlID="dataHeSoLd" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLd" Text='<%# Bind("HeSoLd") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLd" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLd" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoTinChi" runat="server" Text="He So Tin Chi:" AssociatedControlID="dataHeSoTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoTinChi" Text='<%# Bind("HeSoTinChi") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataHeSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoTinChi" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataHeSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoTinChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenCoSo" runat="server" Text="Ten Co So:" AssociatedControlID="dataTenCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenCoSo" Text='<%# Bind("TenCoSo") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaMonHoc" runat="server" Display="Dynamic" ControlToValidate="dataMaMonHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMonHoc" runat="server" Text="Ten Mon Hoc:" AssociatedControlID="dataTenMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMonHoc" Text='<%# Bind("TenMonHoc") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataTenMonHoc" runat="server" Display="Dynamic" ControlToValidate="dataTenMonHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


