<%@ Control Language="C#" ClassName="ThanhTraCoiThiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiDiemGhiNhan" runat="server" Text="Thoi Diem Ghi Nhan:" AssociatedControlID="dataThoiDiemGhiNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiDiemGhiNhan" Text='<%# Bind("ThoiDiemGhiNhan") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLyDo" runat="server" Text="Ly Do:" AssociatedControlID="dataLyDo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLyDo" Text='<%# Bind("LyDo") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoThanhTra" runat="server" Text="Si So Thanh Tra:" AssociatedControlID="dataSiSoThanhTra" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoThanhTra" Text='<%# Bind("SiSoThanhTra") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoThanhTra" runat="server" Display="Dynamic" ControlToValidate="dataSiSoThanhTra" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaViPham" runat="server" Text="Ma Vi Pham:" AssociatedControlID="dataMaViPham" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaViPham" Text='<%# Bind("MaViPham") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHinhThucViPhamHrm" runat="server" Text="Ma Hinh Thuc Vi Pham Hrm:" AssociatedControlID="dataMaHinhThucViPhamHrm" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataMaHinhThucViPhamHrm" Value='<%# Bind("MaHinhThucViPhamHrm") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiHocPhan" runat="server" Text="Ma Loai Hoc Phan:" AssociatedControlID="dataMaLoaiHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiHocPhan" Text='<%# Bind("MaLoaiHocPhan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaLoaiHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiHocPhan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataXacNhan" runat="server" Text="Xac Nhan:" AssociatedControlID="dataXacNhan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataXacNhan" SelectedValue='<%# Bind("XacNhan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
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
        <td class="literal"><asp:Label ID="lbldataSoLuongSinhVien" runat="server" Text="So Luong Sinh Vien:" AssociatedControlID="dataSoLuongSinhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLuongSinhVien" Text='<%# Bind("SoLuongSinhVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLuongSinhVien" runat="server" Display="Dynamic" ControlToValidate="dataSoLuongSinhVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiGianBatDau" runat="server" Text="Thoi Gian Bat Dau:" AssociatedControlID="dataThoiGianBatDau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiGianBatDau" Text='<%# Bind("ThoiGianBatDau") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaPhong" runat="server" Text="Ma Phong:" AssociatedControlID="dataMaPhong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaPhong" Text='<%# Bind("MaPhong") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayThi" runat="server" Text="Ngay Thi:" AssociatedControlID="dataNgayThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayThi" Text='<%# Bind("NgayThi") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataExamination" runat="server" Text="Examination:" AssociatedControlID="dataExamination" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataExamination" Text='<%# Bind("Examination") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataExamination" runat="server" Display="Dynamic" ControlToValidate="dataExamination" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataExamination" runat="server" Display="Dynamic" ControlToValidate="dataExamination" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaCanBoCoiThi" runat="server" Text="Ma Can Bo Coi Thi:" AssociatedControlID="dataMaCanBoCoiThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaCanBoCoiThi" Text='<%# Bind("MaCanBoCoiThi") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaCanBoCoiThi" runat="server" Display="Dynamic" ControlToValidate="dataMaCanBoCoiThi" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietBatDau" runat="server" Text="Tiet Bat Dau:" AssociatedControlID="dataTietBatDau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietBatDau" Text='<%# Bind("TietBatDau") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietBatDau" runat="server" Display="Dynamic" ControlToValidate="dataTietBatDau" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopSinhVien" runat="server" Text="Ma Lop Sinh Vien:" AssociatedControlID="dataMaLopSinhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopSinhVien" Text='<%# Bind("MaLopSinhVien") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiGianLamBai" runat="server" Text="Thoi Gian Lam Bai:" AssociatedControlID="dataThoiGianLamBai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiGianLamBai" Text='<%# Bind("ThoiGianLamBai") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMonHoc" runat="server" Text="Ten Mon Hoc:" AssociatedControlID="dataTenMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMonHoc" Text='<%# Bind("TenMonHoc") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


