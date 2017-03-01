<%@ Control Language="C#" ClassName="ThuLaoChamBaiVhuFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongCong" runat="server" Text="Tong Cong:" AssociatedControlID="dataTongCong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongCong" Text='<%# Bind("TongCong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongCong" runat="server" Display="Dynamic" ControlToValidate="dataTongCong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTienLan2" runat="server" Text="Thanh Tien Lan2:" AssociatedControlID="dataThanhTienLan2" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTienLan2" Text='<%# Bind("ThanhTienLan2") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTienLan2" runat="server" Display="Dynamic" ControlToValidate="dataThanhTienLan2" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoi" runat="server" Text="He So Quy Doi:" AssociatedControlID="dataHeSoQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoi" Text='<%# Bind("HeSoQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHinhThucThi" runat="server" Text="Hinh Thuc Thi:" AssociatedControlID="dataHinhThucThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHinhThucThi" Text='<%# Bind("HinhThucThi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucChamCuoiKy" runat="server" Text="Dinh Muc Cham Cuoi Ky:" AssociatedControlID="dataDinhMucChamCuoiKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucChamCuoiKy" Text='<%# Bind("DinhMucChamCuoiKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucChamCuoiKy" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucChamCuoiKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuLaoChamGiuaKy" runat="server" Text="Thu Lao Cham Giua Ky:" AssociatedControlID="dataThuLaoChamGiuaKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuLaoChamGiuaKy" Text='<%# Bind("ThuLaoChamGiuaKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuLaoChamGiuaKy" runat="server" Display="Dynamic" ControlToValidate="dataThuLaoChamGiuaKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTienLan1" runat="server" Text="Thanh Tien Lan1:" AssociatedControlID="dataThanhTienLan1" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTienLan1" Text='<%# Bind("ThanhTienLan1") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTienLan1" runat="server" Display="Dynamic" ControlToValidate="dataThanhTienLan1" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuLaoChamCuoiKy" runat="server" Text="Thu Lao Cham Cuoi Ky:" AssociatedControlID="dataThuLaoChamCuoiKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuLaoChamCuoiKy" Text='<%# Bind("ThuLaoChamCuoiKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuLaoChamCuoiKy" runat="server" Display="Dynamic" ControlToValidate="dataThuLaoChamCuoiKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
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
        <td class="literal"><asp:Label ID="lbldataSoBaiLan2" runat="server" Text="So Bai Lan2:" AssociatedControlID="dataSoBaiLan2" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiLan2" Text='<%# Bind("SoBaiLan2") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiLan2" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiLan2" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiGiangVien" Text='<%# Bind("MaLoaiGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaLoaiGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChot" runat="server" Text="Chot:" AssociatedControlID="dataChot" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataChot" SelectedValue='<%# Bind("Chot") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietQuyDoi" runat="server" Text="So Tiet Quy Doi:" AssociatedControlID="dataSoTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietQuyDoi" Text='<%# Bind("SoTietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataSoTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKhoaNganh" runat="server" Text="Khoa Nganh:" AssociatedControlID="dataKhoaNganh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKhoaNganh" Text='<%# Bind("KhoaNganh") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocPhan" runat="server" Text="Ma Hoc Phan:" AssociatedControlID="dataMaHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocPhan" Text='<%# Bind("MaHocPhan") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNganh" runat="server" Text="Nganh:" AssociatedControlID="dataNganh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNganh" Text='<%# Bind("Nganh") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataLanThi" runat="server" Text="Lan Thi:" AssociatedControlID="dataLanThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLanThi" Text='<%# Bind("LanThi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKyThi" runat="server" Text="Ky Thi:" AssociatedControlID="dataKyThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKyThi" Text='<%# Bind("KyThi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSo" runat="server" Text="Si So:" AssociatedControlID="dataSiSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSo" Text='<%# Bind("SiSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSo" runat="server" Display="Dynamic" ControlToValidate="dataSiSo" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLopSinhVien" runat="server" Text="Lop Sinh Vien:" AssociatedControlID="dataLopSinhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLopSinhVien" Text='<%# Bind("LopSinhVien") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDinhMucChamGiuaKy" runat="server" Text="Dinh Muc Cham Giua Ky:" AssociatedControlID="dataDinhMucChamGiuaKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDinhMucChamGiuaKy" Text='<%# Bind("DinhMucChamGiuaKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDinhMucChamGiuaKy" runat="server" Display="Dynamic" ControlToValidate="dataDinhMucChamGiuaKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiGianThi" runat="server" Text="Thoi Gian Thi:" AssociatedControlID="dataThoiGianThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiGianThi" Text='<%# Bind("ThoiGianThi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHocPhan" runat="server" Text="Ten Hoc Phan:" AssociatedControlID="dataTenHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHocPhan" Text='<%# Bind("TenHocPhan") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBacDaoTao" runat="server" Text="Bac Dao Tao:" AssociatedControlID="dataBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataBacDaoTao" Text='<%# Bind("BacDaoTao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTinChi" runat="server" Text="So Tin Chi:" AssociatedControlID="dataSoTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTinChi" Text='<%# Bind("SoTinChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataSoTinChi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


