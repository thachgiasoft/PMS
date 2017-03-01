<%@ Control Language="C#" ClassName="ThuLaoChamBaiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataThucLanh" runat="server" Text="Thuc Lanh:" AssociatedControlID="dataThucLanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThucLanh" Text='<%# Bind("ThucLanh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThucLanh" runat="server" Display="Dynamic" ControlToValidate="dataThucLanh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTienCuoiKy" runat="server" Text="Tien Cuoi Ky:" AssociatedControlID="dataTienCuoiKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTienCuoiKy" Text='<%# Bind("TienCuoiKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTienCuoiKy" runat="server" Display="Dynamic" ControlToValidate="dataTienCuoiKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongCong" runat="server" Text="Tong Cong:" AssociatedControlID="dataTongCong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongCong" Text='<%# Bind("TongCong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongCong" runat="server" Display="Dynamic" ControlToValidate="dataTongCong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThue" runat="server" Text="Thue:" AssociatedControlID="dataThue" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThue" Text='<%# Bind("Thue") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThue" runat="server" Display="Dynamic" ControlToValidate="dataThue" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBacDaoTao" runat="server" Text="Ma Bac Dao Tao:" AssociatedControlID="dataMaBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBacDaoTao" Text='<%# Bind("MaBacDaoTao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucChi" runat="server" Text="Muc Chi:" AssociatedControlID="dataMucChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMucChi" Text='<%# Bind("MucChi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHinhThucThi" runat="server" Text="Ma Hinh Thuc Thi:" AssociatedControlID="dataMaHinhThucThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHinhThucThi" Text='<%# Bind("MaHinhThucThi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChot" runat="server" Text="Chot:" AssociatedControlID="dataChot" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataChot" SelectedValue='<%# Bind("Chot") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotChiTra" runat="server" Text="Dot Chi Tra:" AssociatedControlID="dataDotChiTra" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotChiTra" Text='<%# Bind("DotChiTra") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataIsSync" runat="server" Text="Is Sync:" AssociatedControlID="dataIsSync" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataIsSync" SelectedValue='<%# Bind("IsSync") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLanThi" runat="server" Text="Lan Thi:" AssociatedControlID="dataLanThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLanThi" Text='<%# Bind("LanThi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKyThi" runat="server" Text="Ky Thi:" AssociatedControlID="dataKyThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKyThi" Text='<%# Bind("KyThi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVienQuanLy" runat="server" Text="Ma Giang Vien Quan Ly:" AssociatedControlID="dataMaGiangVienQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVienQuanLy" Text='<%# Bind("MaGiangVienQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocPhan" runat="server" Text="Ma Hoc Phan:" AssociatedControlID="dataMaHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocPhan" Text='<%# Bind("MaHocPhan") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBaiGiuaKy" runat="server" Text="So Bai Giua Ky:" AssociatedControlID="dataSoBaiGiuaKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiGiuaKy" Text='<%# Bind("SoBaiGiuaKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiGiuaKy" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiGiuaKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaCuoiKy" runat="server" Text="Don Gia Cuoi Ky:" AssociatedControlID="dataDonGiaCuoiKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaCuoiKy" Text='<%# Bind("DonGiaCuoiKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaCuoiKy" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaCuoiKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTienGiuaKy" runat="server" Text="Tien Giua Ky:" AssociatedControlID="dataTienGiuaKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTienGiuaKy" Text='<%# Bind("TienGiuaKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTienGiuaKy" runat="server" Display="Dynamic" ControlToValidate="dataTienGiuaKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTienQuaTrinh" runat="server" Text="Tien Qua Trinh:" AssociatedControlID="dataTienQuaTrinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTienQuaTrinh" Text='<%# Bind("TienQuaTrinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTienQuaTrinh" runat="server" Display="Dynamic" ControlToValidate="dataTienQuaTrinh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaQuaTrinh" runat="server" Text="Don Gia Qua Trinh:" AssociatedControlID="dataDonGiaQuaTrinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaQuaTrinh" Text='<%# Bind("DonGiaQuaTrinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaQuaTrinh" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaQuaTrinh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBaiQuaTrinh" runat="server" Text="So Bai Qua Trinh:" AssociatedControlID="dataSoBaiQuaTrinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiQuaTrinh" Text='<%# Bind("SoBaiQuaTrinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiQuaTrinh" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiQuaTrinh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBaiCuoiKy" runat="server" Text="So Bai Cuoi Ky:" AssociatedControlID="dataSoBaiCuoiKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBaiCuoiKy" Text='<%# Bind("SoBaiCuoiKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBaiCuoiKy" runat="server" Display="Dynamic" ControlToValidate="dataSoBaiCuoiKy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaGiuaKy" runat="server" Text="Don Gia Giua Ky:" AssociatedControlID="dataDonGiaGiuaKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaGiuaKy" Text='<%# Bind("DonGiaGiuaKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaGiuaKy" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaGiuaKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


