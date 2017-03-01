<%@ Control Language="C#" ClassName="ThanhTraTheoThoiKhoaBieuFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietBatDau" runat="server" Text="Tiet Bat Dau:" AssociatedControlID="dataTietBatDau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietBatDau" Text='<%# Bind("TietBatDau") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietBatDau" runat="server" Display="Dynamic" ControlToValidate="dataTietBatDau" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgay" runat="server" Text="Ngay:" AssociatedControlID="dataNgay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgay" Text='<%# Bind("Ngay") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietGhiNhan" runat="server" Text="So Tiet Ghi Nhan:" AssociatedControlID="dataSoTietGhiNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietGhiNhan" Text='<%# Bind("SoTietGhiNhan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietGhiNhan" runat="server" Display="Dynamic" ControlToValidate="dataSoTietGhiNhan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaCanBoGiangDay" runat="server" Text="Ma Can Bo Giang Day:" AssociatedControlID="dataMaCanBoGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaCanBoGiangDay" Text='<%# Bind("MaCanBoGiangDay") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaCanBoGiangDay" runat="server" Display="Dynamic" ControlToValidate="dataMaCanBoGiangDay" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaXacNhan" runat="server" Text="Da Xac Nhan:" AssociatedControlID="dataDaXacNhan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDaXacNhan" SelectedValue='<%# Bind("DaXacNhan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhLy" runat="server" Text="Thanh Ly:" AssociatedControlID="dataThanhLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhLy" Text='<%# Bind("ThanhLy") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietQuyDoi" runat="server" Text="So Tiet Quy Doi:" AssociatedControlID="dataSoTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietQuyDoi" Text='<%# Bind("SoTietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataSoTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhong" runat="server" Text="Phong:" AssociatedControlID="dataPhong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhong" Text='<%# Bind("Phong") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataXacNhan" runat="server" Text="Xac Nhan:" AssociatedControlID="dataXacNhan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataXacNhan" SelectedValue='<%# Bind("XacNhan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSo" runat="server" Text="Si So:" AssociatedControlID="dataSiSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSo" Text='<%# Bind("SiSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSo" runat="server" Display="Dynamic" ControlToValidate="dataSiSo" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiDiemGhiNhan" runat="server" Text="Thoi Diem Ghi Nhan:" AssociatedControlID="dataThoiDiemGhiNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiDiemGhiNhan" Text='<%# Bind("ThoiDiemGhiNhan") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHinhThucViPhamHrm" runat="server" Text="Ma Hinh Thuc Vi Pham Hrm:" AssociatedControlID="dataMaHinhThucViPhamHrm" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataMaHinhThucViPhamHrm" Value='<%# Bind("MaHinhThucViPhamHrm") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLichHoc" runat="server" Text="Ma Lich Hoc:" AssociatedControlID="dataMaLichHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLichHoc" Text='<%# Bind("MaLichHoc") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLichHoc" runat="server" Display="Dynamic" ControlToValidate="dataMaLichHoc" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMaLichHoc" runat="server" Display="Dynamic" ControlToValidate="dataMaLichHoc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaViPham" runat="server" Text="Ma Vi Pham:" AssociatedControlID="dataMaViPham" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaViPham" Text='<%# Bind("MaViPham") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLyDo" runat="server" Text="Ly Do:" AssociatedControlID="dataLyDo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLyDo" Text='<%# Bind("LyDo") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


