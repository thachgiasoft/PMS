<%@ Control Language="C#" ClassName="ThuMoiGiangHopDongThinhGiangFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoi" runat="server" Text="Tiet Quy Doi:" AssociatedControlID="dataTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoi" Text='<%# Bind("TietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoTinChi" runat="server" Text="He So Tin Chi:" AssociatedControlID="dataHeSoTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoTinChi" Text='<%# Bind("HeSoTinChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoTinChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLd" runat="server" Text="He So Ld:" AssociatedControlID="dataHeSoLd" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLd" Text='<%# Bind("HeSoLd") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLd" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLd" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayBatDauDay" runat="server" Text="Ngay Bat Dau Day:" AssociatedControlID="dataNgayBatDauDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayBatDauDay" Text='<%# Bind("NgayBatDauDay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayBatDauDay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHoanTat" runat="server" Text="Hoan Tat:" AssociatedControlID="dataHoanTat" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataHoanTat" SelectedValue='<%# Bind("HoanTat") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopSinhVien" runat="server" Text="Ma Lop Sinh Vien:" AssociatedControlID="dataMaLopSinhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopSinhVien" Text='<%# Bind("MaLopSinhVien") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLopSinhVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLopSinhVien" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayKetThucDay" runat="server" Text="Ngay Ket Thuc Day:" AssociatedControlID="dataNgayKetThucDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayKetThucDay" Text='<%# Bind("NgayKetThucDay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayKetThucDay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBacDaoTao" runat="server" Text="Ma Bac Dao Tao:" AssociatedControlID="dataMaBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBacDaoTao" Text='<%# Bind("MaBacDaoTao") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaBacDaoTao" runat="server" Display="Dynamic" ControlToValidate="dataMaBacDaoTao" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="30"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLopHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLopHocPhan" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiHinh" runat="server" Text="Ma Loai Hinh:" AssociatedControlID="dataMaLoaiHinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiHinh" Text='<%# Bind("MaLoaiHinh") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLoaiHinh" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiHinh" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoLop" runat="server" Text="Si So Lop:" AssociatedControlID="dataSiSoLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoLop" Text='<%# Bind("SiSoLop") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoLop" runat="server" Display="Dynamic" ControlToValidate="dataSiSoLop" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaMonHoc" runat="server" Display="Dynamic" ControlToValidate="dataMaMonHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


