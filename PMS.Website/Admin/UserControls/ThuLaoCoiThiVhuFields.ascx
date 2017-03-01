<%@ Control Language="C#" ClassName="ThuLaoCoiThiVhuFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietQuyDoi" runat="server" Text="So Tiet Quy Doi:" AssociatedControlID="dataSoTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietQuyDoi" Text='<%# Bind("SoTietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataSoTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoi" runat="server" Text="He So Quy Doi:" AssociatedControlID="dataHeSoQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoi" Text='<%# Bind("HeSoQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuLaoCoiThi120" runat="server" Text="Thu Lao Coi Thi120:" AssociatedControlID="dataThuLaoCoiThi120" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuLaoCoiThi120" Text='<%# Bind("ThuLaoCoiThi120") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuLaoCoiThi120" runat="server" Display="Dynamic" ControlToValidate="dataThuLaoCoiThi120" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongCong" runat="server" Text="Tong Cong:" AssociatedControlID="dataTongCong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongCong" Text='<%# Bind("TongCong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongCong" runat="server" Display="Dynamic" ControlToValidate="dataTongCong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiGiangVien" Text='<%# Bind("MaLoaiGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaLoaiGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChot" runat="server" Text="Chot:" AssociatedControlID="dataChot" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataChot" SelectedValue='<%# Bind("Chot") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLanThi" runat="server" Text="Lan Thi:" AssociatedControlID="dataLanThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLanThi" Text='<%# Bind("LanThi") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKyThi" runat="server" Text="Ky Thi:" AssociatedControlID="dataKyThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKyThi" Text='<%# Bind("KyThi") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVienQuanLy" runat="server" Text="Ma Giang Vien Quan Ly:" AssociatedControlID="dataMaGiangVienQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVienQuanLy" Text='<%# Bind("MaGiangVienQuanLy") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataThuLaoCoiThi90" runat="server" Text="Thu Lao Coi Thi90:" AssociatedControlID="dataThuLaoCoiThi90" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuLaoCoiThi90" Text='<%# Bind("ThuLaoCoiThi90") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuLaoCoiThi90" runat="server" Display="Dynamic" ControlToValidate="dataThuLaoCoiThi90" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBuoiCoiThi120" runat="server" Text="So Buoi Coi Thi120:" AssociatedControlID="dataSoBuoiCoiThi120" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBuoiCoiThi120" Text='<%# Bind("SoBuoiCoiThi120") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBuoiCoiThi120" runat="server" Display="Dynamic" ControlToValidate="dataSoBuoiCoiThi120" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBuoiCoiThi90" runat="server" Text="So Buoi Coi Thi90:" AssociatedControlID="dataSoBuoiCoiThi90" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBuoiCoiThi90" Text='<%# Bind("SoBuoiCoiThi90") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBuoiCoiThi90" runat="server" Display="Dynamic" ControlToValidate="dataSoBuoiCoiThi90" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBuoiCoiThi75" runat="server" Text="So Buoi Coi Thi75:" AssociatedControlID="dataSoBuoiCoiThi75" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBuoiCoiThi75" Text='<%# Bind("SoBuoiCoiThi75") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBuoiCoiThi75" runat="server" Display="Dynamic" ControlToValidate="dataSoBuoiCoiThi75" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuLaoCoiThi75" runat="server" Text="Thu Lao Coi Thi75:" AssociatedControlID="dataThuLaoCoiThi75" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuLaoCoiThi75" Text='<%# Bind("ThuLaoCoiThi75") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuLaoCoiThi75" runat="server" Display="Dynamic" ControlToValidate="dataThuLaoCoiThi75" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


