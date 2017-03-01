<%@ Control Language="C#" ClassName="ChiTienThuLaoGiangDayFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayLayDuLieu" runat="server" Text="Ngay Lay Du Lieu:" AssociatedControlID="dataNgayLayDuLieu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayLayDuLieu" Text='<%# Bind("NgayLayDuLieu") %>' MaxLength="50"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLopClc" runat="server" Text="Lop Clc:" AssociatedControlID="dataLopClc" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataLopClc" SelectedValue='<%# Bind("LopClc") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopSinhVien" runat="server" Text="Ma Lop Sinh Vien:" AssociatedControlID="dataMaLopSinhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopSinhVien" Text='<%# Bind("MaLopSinhVien") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongSoTietQuyDoi" runat="server" Text="Tong So Tiet Quy Doi:" AssociatedControlID="dataTongSoTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongSoTietQuyDoi" Text='<%# Bind("TongSoTietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongSoTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTongSoTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaCanBoGiangDay" runat="server" Text="Ma Can Bo Giang Day:" AssociatedControlID="dataMaCanBoGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaCanBoGiangDay" Text='<%# Bind("MaCanBoGiangDay") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataOid" runat="server" Text="Oid:" AssociatedControlID="dataOid" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataOid" Value='<%# Bind("Oid") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoChungTuHrm" runat="server" Text="So Chung Tu Hrm:" AssociatedControlID="dataSoChungTuHrm" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoChungTuHrm" Text='<%# Bind("SoChungTuHrm") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongTien" runat="server" Text="Tong Tien:" AssociatedControlID="dataTongTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongTien" Text='<%# Bind("TongTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongTien" runat="server" Display="Dynamic" ControlToValidate="dataTongTien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLaGiangVienThinhGiang" runat="server" Text="La Giang Vien Thinh Giang:" AssociatedControlID="dataLaGiangVienThinhGiang" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataLaGiangVienThinhGiang" SelectedValue='<%# Bind("LaGiangVienThinhGiang") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


