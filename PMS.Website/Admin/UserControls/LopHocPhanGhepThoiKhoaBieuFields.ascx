<%@ Control Language="C#" ClassName="LopHocPhanGhepThoiKhoaBieuFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataLopChinh" runat="server" Text="Lop Chinh:" AssociatedControlID="dataLopChinh" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataLopChinh" SelectedValue='<%# Bind("LopChinh") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopSauGhep" runat="server" Text="Ma Lop Sau Ghep:" AssociatedControlID="dataMaLopSauGhep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopSauGhep" Text='<%# Bind("MaLopSauGhep") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopTruocGhep" runat="server" Text="Ma Lop Truoc Ghep:" AssociatedControlID="dataMaLopTruocGhep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopTruocGhep" Text='<%# Bind("MaLopTruocGhep") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoSauGhep" runat="server" Text="Si So Sau Ghep:" AssociatedControlID="dataSiSoSauGhep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoSauGhep" Text='<%# Bind("SiSoSauGhep") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoSauGhep" runat="server" Display="Dynamic" ControlToValidate="dataSiSoSauGhep" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaCanBoGiangDay" runat="server" Text="Ma Can Bo Giang Day:" AssociatedControlID="dataMaCanBoGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaCanBoGiangDay" Text='<%# Bind("MaCanBoGiangDay") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoThuTu" runat="server" Text="So Thu Tu:" AssociatedControlID="dataSoThuTu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoThuTu" Text='<%# Bind("SoThuTu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoThuTu" runat="server" Display="Dynamic" ControlToValidate="dataSoThuTu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoTruocGhep" runat="server" Text="Si So Truoc Ghep:" AssociatedControlID="dataSiSoTruocGhep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoTruocGhep" Text='<%# Bind("SiSoTruocGhep") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoTruocGhep" runat="server" Display="Dynamic" ControlToValidate="dataSiSoTruocGhep" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBacDaoTao" runat="server" Text="Ma Bac Dao Tao:" AssociatedControlID="dataMaBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBacDaoTao" Text='<%# Bind("MaBacDaoTao") %>' MaxLength="20"></asp:TextBox>
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


