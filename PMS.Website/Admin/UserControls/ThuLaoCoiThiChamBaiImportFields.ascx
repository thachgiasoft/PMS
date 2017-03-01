<%@ Control Language="C#" ClassName="ThuLaoCoiThiChamBaiImportFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
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
        <td class="literal"><asp:Label ID="lbldataBacDaoTao" runat="server" Text="Bac Dao Tao:" AssociatedControlID="dataBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataBacDaoTao" Text='<%# Bind("BacDaoTao") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaCuoiKy" runat="server" Text="Don Gia Cuoi Ky:" AssociatedControlID="dataDonGiaCuoiKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaCuoiKy" Text='<%# Bind("DonGiaCuoiKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaCuoiKy" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaCuoiKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTien" runat="server" Text="Thanh Tien:" AssociatedControlID="dataThanhTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTien" Text='<%# Bind("ThanhTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTien" runat="server" Display="Dynamic" ControlToValidate="dataThanhTien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTienCoiThi" runat="server" Text="So Tien Coi Thi:" AssociatedControlID="dataSoTienCoiThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTienCoiThi" Text='<%# Bind("SoTienCoiThi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTienCoiThi" runat="server" Display="Dynamic" ControlToValidate="dataSoTienCoiThi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioCoiThi" runat="server" Text="Gio Coi Thi:" AssociatedControlID="dataGioCoiThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioCoiThi" Text='<%# Bind("GioCoiThi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioCoiThi" runat="server" Display="Dynamic" ControlToValidate="dataGioCoiThi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioNhapDiem" runat="server" Text="Gio Nhap Diem:" AssociatedControlID="dataGioNhapDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioNhapDiem" Text='<%# Bind("GioNhapDiem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioNhapDiem" runat="server" Display="Dynamic" ControlToValidate="dataGioNhapDiem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongCong" runat="server" Text="Tong Cong:" AssociatedControlID="dataTongCong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongCong" Text='<%# Bind("TongCong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongCong" runat="server" Display="Dynamic" ControlToValidate="dataTongCong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiHinHdaoTao" runat="server" Text="Loai Hin Hdao Tao:" AssociatedControlID="dataLoaiHinHdaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiHinHdaoTao" Text='<%# Bind("LoaiHinHdaoTao") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioChamThi" runat="server" Text="Gio Cham Thi:" AssociatedControlID="dataGioChamThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioChamThi" Text='<%# Bind("GioChamThi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioChamThi" runat="server" Display="Dynamic" ControlToValidate="dataGioChamThi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioRaDe" runat="server" Text="Gio Ra De:" AssociatedControlID="dataGioRaDe" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioRaDe" Text='<%# Bind("GioRaDe") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioRaDe" runat="server" Display="Dynamic" ControlToValidate="dataGioRaDe" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioToChucThi" runat="server" Text="Gio To Chuc Thi:" AssociatedControlID="dataGioToChucThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioToChucThi" Text='<%# Bind("GioToChucThi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioToChucThi" runat="server" Display="Dynamic" ControlToValidate="dataGioToChucThi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaGiuaKy" runat="server" Text="Don Gia Giua Ky:" AssociatedControlID="dataDonGiaGiuaKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaGiuaKy" Text='<%# Bind("DonGiaGiuaKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaGiuaKy" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaGiuaKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVienQuanLy" runat="server" Text="Ma Giang Vien Quan Ly:" AssociatedControlID="dataMaGiangVienQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVienQuanLy" Text='<%# Bind("MaGiangVienQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHoTen" runat="server" Text="Ho Ten:" AssociatedControlID="dataHoTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHoTen" Text='<%# Bind("HoTen") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDungChi" runat="server" Text="Noi Dung Chi:" AssociatedControlID="dataNoiDungChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDungChi" Text='<%# Bind("NoiDungChi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataDotChiTra" runat="server" Text="Dot Chi Tra:" AssociatedControlID="dataDotChiTra" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotChiTra" Text='<%# Bind("DotChiTra") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBaiGiuaKy" runat="server" Text="So Bai Giua Ky:" AssociatedControlID="dataSoBaiGiuaKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiGiuaKy" Text='<%# Bind("SoBaiGiuaKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiGiuaKy" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiGiuaKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBaiCuoiKy" runat="server" Text="So Bai Cuoi Ky:" AssociatedControlID="dataSoBaiCuoiKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiCuoiKy" Text='<%# Bind("SoBaiCuoiKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiCuoiKy" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiCuoiKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaQuaTrinh" runat="server" Text="Don Gia Qua Trinh:" AssociatedControlID="dataDonGiaQuaTrinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaQuaTrinh" Text='<%# Bind("DonGiaQuaTrinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaQuaTrinh" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaQuaTrinh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMonHoc" runat="server" Text="Ten Mon Hoc:" AssociatedControlID="dataTenMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMonHoc" Text='<%# Bind("TenMonHoc") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBaiQuaTrinh" runat="server" Text="So Bai Qua Trinh:" AssociatedControlID="dataSoBaiQuaTrinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiQuaTrinh" Text='<%# Bind("SoBaiQuaTrinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiQuaTrinh" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiQuaTrinh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


